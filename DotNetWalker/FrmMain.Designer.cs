namespace DotNetWalker
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAssemblypath = new System.Windows.Forms.Label();
            this.txtAssemblyPath = new System.Windows.Forms.TextBox();
            this.btnLoadAssembly = new System.Windows.Forms.Button();
            this.ofdAssembly = new System.Windows.Forms.OpenFileDialog();
            this.btnCopyRefrencedAssemblies = new System.Windows.Forms.Button();
            this.cbExcludeDotNetAssemblies = new System.Windows.Forms.CheckBox();
            this.fbdCopyDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.scSpiliter = new System.Windows.Forms.SplitContainer();
            this.lblFounded = new System.Windows.Forms.Label();
            this.lblFoundAssemblies = new System.Windows.Forms.ListBox();
            this.lblNofFound = new System.Windows.Forms.Label();
            this.lbNotFoundAssemblies = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.scSpiliter)).BeginInit();
            this.scSpiliter.Panel1.SuspendLayout();
            this.scSpiliter.Panel2.SuspendLayout();
            this.scSpiliter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAssemblypath
            // 
            this.lblAssemblypath.AutoSize = true;
            this.lblAssemblypath.Location = new System.Drawing.Point(12, 18);
            this.lblAssemblypath.Name = "lblAssemblypath";
            this.lblAssemblypath.Size = new System.Drawing.Size(76, 13);
            this.lblAssemblypath.TabIndex = 0;
            this.lblAssemblypath.Text = "Assembly Path";
            // 
            // txtAssemblyPath
            // 
            this.txtAssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssemblyPath.Enabled = false;
            this.txtAssemblyPath.Location = new System.Drawing.Point(120, 15);
            this.txtAssemblyPath.Name = "txtAssemblyPath";
            this.txtAssemblyPath.ReadOnly = true;
            this.txtAssemblyPath.Size = new System.Drawing.Size(528, 20);
            this.txtAssemblyPath.TabIndex = 0;
            this.txtAssemblyPath.TabStop = false;
            // 
            // btnLoadAssembly
            // 
            this.btnLoadAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadAssembly.Location = new System.Drawing.Point(654, 15);
            this.btnLoadAssembly.Name = "btnLoadAssembly";
            this.btnLoadAssembly.Size = new System.Drawing.Size(30, 20);
            this.btnLoadAssembly.TabIndex = 0;
            this.btnLoadAssembly.Text = "...";
            this.btnLoadAssembly.UseVisualStyleBackColor = true;
            this.btnLoadAssembly.Click += new System.EventHandler(this.btnLoadAssembly_Click);
            // 
            // ofdAssembly
            // 
            this.ofdAssembly.Filter = ".Net executable files (*.exe,*.dll)|*.exe;*.dll";
            // 
            // btnCopyRefrencedAssemblies
            // 
            this.btnCopyRefrencedAssemblies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyRefrencedAssemblies.Location = new System.Drawing.Point(12, 435);
            this.btnCopyRefrencedAssemblies.Name = "btnCopyRefrencedAssemblies";
            this.btnCopyRefrencedAssemblies.Size = new System.Drawing.Size(923, 23);
            this.btnCopyRefrencedAssemblies.TabIndex = 5;
            this.btnCopyRefrencedAssemblies.Text = "Copy refrenced assemblies";
            this.btnCopyRefrencedAssemblies.UseVisualStyleBackColor = true;
            this.btnCopyRefrencedAssemblies.Click += new System.EventHandler(this.btnCopyAssemblies_Click);
            // 
            // cbExcludeDotNetAssemblies
            // 
            this.cbExcludeDotNetAssemblies.AutoSize = true;
            this.cbExcludeDotNetAssemblies.Checked = true;
            this.cbExcludeDotNetAssemblies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExcludeDotNetAssemblies.Location = new System.Drawing.Point(696, 17);
            this.cbExcludeDotNetAssemblies.Name = "cbExcludeDotNetAssemblies";
            this.cbExcludeDotNetAssemblies.Size = new System.Drawing.Size(239, 17);
            this.cbExcludeDotNetAssemblies.TabIndex = 1;
            this.cbExcludeDotNetAssemblies.Text = "Exclude Microsoft .Net framework assemblies";
            this.cbExcludeDotNetAssemblies.UseVisualStyleBackColor = true;
            // 
            // scSpiliter
            // 
            this.scSpiliter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scSpiliter.Location = new System.Drawing.Point(12, 49);
            this.scSpiliter.Name = "scSpiliter";
            this.scSpiliter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSpiliter.Panel1
            // 
            this.scSpiliter.Panel1.Controls.Add(this.lblFounded);
            this.scSpiliter.Panel1.Controls.Add(this.lblFoundAssemblies);
            this.scSpiliter.Panel1MinSize = 100;
            // 
            // scSpiliter.Panel2
            // 
            this.scSpiliter.Panel2.Controls.Add(this.lblNofFound);
            this.scSpiliter.Panel2.Controls.Add(this.lbNotFoundAssemblies);
            this.scSpiliter.Panel2MinSize = 100;
            this.scSpiliter.Size = new System.Drawing.Size(923, 374);
            this.scSpiliter.SplitterDistance = 193;
            this.scSpiliter.SplitterIncrement = 5;
            this.scSpiliter.SplitterWidth = 10;
            this.scSpiliter.TabIndex = 8;
            // 
            // lblFounded
            // 
            this.lblFounded.AutoSize = true;
            this.lblFounded.Location = new System.Drawing.Point(3, 3);
            this.lblFounded.Name = "lblFounded";
            this.lblFounded.Size = new System.Drawing.Size(49, 13);
            this.lblFounded.TabIndex = 5;
            this.lblFounded.Text = "Founded";
            // 
            // lblFoundAssemblies
            // 
            this.lblFoundAssemblies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoundAssemblies.FormattingEnabled = true;
            this.lblFoundAssemblies.Location = new System.Drawing.Point(2, 18);
            this.lblFoundAssemblies.Name = "lblFoundAssemblies";
            this.lblFoundAssemblies.Size = new System.Drawing.Size(923, 173);
            this.lblFoundAssemblies.TabIndex = 4;
            this.lblFoundAssemblies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblFoundAssemblies_MouseDoubleClick);
            // 
            // lblNofFound
            // 
            this.lblNofFound.AutoSize = true;
            this.lblNofFound.Location = new System.Drawing.Point(4, 4);
            this.lblNofFound.Name = "lblNofFound";
            this.lblNofFound.Size = new System.Drawing.Size(54, 13);
            this.lblNofFound.TabIndex = 9;
            this.lblNofFound.Text = "Not found";
            // 
            // lbNotFoundAssemblies
            // 
            this.lbNotFoundAssemblies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNotFoundAssemblies.FormattingEnabled = true;
            this.lbNotFoundAssemblies.Location = new System.Drawing.Point(0, 22);
            this.lbNotFoundAssemblies.Name = "lbNotFoundAssemblies";
            this.lbNotFoundAssemblies.Size = new System.Drawing.Size(923, 108);
            this.lbNotFoundAssemblies.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 470);
            this.Controls.Add(this.scSpiliter);
            this.Controls.Add(this.cbExcludeDotNetAssemblies);
            this.Controls.Add(this.btnCopyRefrencedAssemblies);
            this.Controls.Add(this.btnLoadAssembly);
            this.Controls.Add(this.txtAssemblyPath);
            this.Controls.Add(this.lblAssemblypath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".Net Walker";
            this.scSpiliter.Panel1.ResumeLayout(false);
            this.scSpiliter.Panel1.PerformLayout();
            this.scSpiliter.Panel2.ResumeLayout(false);
            this.scSpiliter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSpiliter)).EndInit();
            this.scSpiliter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssemblypath;
        private System.Windows.Forms.TextBox txtAssemblyPath;
        private System.Windows.Forms.Button btnLoadAssembly;
        private System.Windows.Forms.OpenFileDialog ofdAssembly;
        private System.Windows.Forms.Button btnCopyRefrencedAssemblies;
        private System.Windows.Forms.CheckBox cbExcludeDotNetAssemblies;
        private System.Windows.Forms.FolderBrowserDialog fbdCopyDestination;
        private System.Windows.Forms.SplitContainer scSpiliter;
        private System.Windows.Forms.ListBox lblFoundAssemblies;
        private System.Windows.Forms.ListBox lbNotFoundAssemblies;
        private System.Windows.Forms.Label lblFounded;
        private System.Windows.Forms.Label lblNofFound;
    }
}

