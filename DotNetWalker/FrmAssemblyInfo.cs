using System.Reflection;
using System.Windows.Forms;

namespace DotNetWalker
{
    public partial class FrmAssemblyInfo : Form
    {
        public FrmAssemblyInfo()
        {
            InitializeComponent();
        }

        public static bool Execute(Assembly assemblyInfo)
        {
            using (var frmAssemblyInfo = new FrmAssemblyInfo())
            {
                frmAssemblyInfo.lblFullName.Text = $"FullName : {assemblyInfo.FullName}";
                frmAssemblyInfo.lblCodebase.Text = $"Codebase : {assemblyInfo.CodeBase}";
                frmAssemblyInfo.lblEntryPoint.Text = $"EntryPoint : {assemblyInfo.EntryPoint}";
                frmAssemblyInfo.lblImageRuntimeVersion.Text = $"ImageRuntimeVersion : {assemblyInfo.ImageRuntimeVersion}";
                frmAssemblyInfo.lblIsDynamic.Text = $"IsDynamic : {assemblyInfo.IsDynamic}";
                frmAssemblyInfo.lblIsFullyTrusted.Text = $"IsFullyTrusted : {assemblyInfo.IsFullyTrusted}";

                return frmAssemblyInfo.ShowDialog() == DialogResult.OK;
            }
        }

        private void FrmAssemblyInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}