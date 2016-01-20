using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DotNetWalker
{
    public partial class FrmMain : Form
    {
        private List<Assembly> _assemblyNames = new List<Assembly>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLoadAssembly_Click(object sender, EventArgs e)
        {
            if (ofdAssembly.ShowDialog() != DialogResult.OK) return;

            txtAssemblyPath.Text = ofdAssembly.FileName;

            // Clear last result
            _assemblyNames.Clear();
            lblFoundAssemblies.Items.Clear();

            var assemblyUtils = new AssemblyUtils();
            assemblyUtils.OnAssemblyNotFound += OnAssemblyNotFound;

            _assemblyNames = assemblyUtils.GetReferencedAssemblies(txtAssemblyPath.Text,
                cbExcludeDotNetAssemblies.Checked,
                new List<Assembly>());

            foreach (var assembly in _assemblyNames)
                lblFoundAssemblies.Items.Add(assembly.FullName);

            MessageBox.Show($"{lblFoundAssemblies.Items.Count} assemblies found", string.Empty, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void OnAssemblyNotFound(AssemblyName assembly)
        {
            lbNotFoundAssemblies.Items.Add(assembly.FullName);
        }

        private void btnCopyAssemblies_Click(object sender, EventArgs e)
        {
            if (fbdCopyDestination.ShowDialog() == DialogResult.OK)
                foreach (var item in _assemblyNames)
                    if (File.Exists(item.Location))
                        File.Copy(item.Location,
                            Path.Combine(fbdCopyDestination.SelectedPath, Path.GetFileName(item.Location)));

            MessageBox.Show(@"All file(s) has been copied !", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblFoundAssemblies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lblFoundAssemblies.SelectedIndex < 0)
                return;

            var selectedAssemblyFullName = lblFoundAssemblies.Items[lblFoundAssemblies.SelectedIndex];
            if (string.IsNullOrEmpty(selectedAssemblyFullName.ToString()))
                return;

            var assemblyInfo = _assemblyNames.FirstOrDefault(f => f.FullName.Equals(selectedAssemblyFullName));
            FrmAssemblyInfo.Execute(assemblyInfo);
        }
    }
}