namespace DotNetWalker
{
    partial class FrmAssemblyInfo
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
            this.lblIsFullyTrusted = new System.Windows.Forms.Label();
            this.lblIsDynamic = new System.Windows.Forms.Label();
            this.lblImageRuntimeVersion = new System.Windows.Forms.Label();
            this.lblEntryPoint = new System.Windows.Forms.Label();
            this.lblCodebase = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIsFullyTrusted
            // 
            this.lblIsFullyTrusted.AutoSize = true;
            this.lblIsFullyTrusted.Location = new System.Drawing.Point(26, 152);
            this.lblIsFullyTrusted.Name = "lblIsFullyTrusted";
            this.lblIsFullyTrusted.Size = new System.Drawing.Size(72, 13);
            this.lblIsFullyTrusted.TabIndex = 11;
            this.lblIsFullyTrusted.Text = "IsFullyTrusted";
            // 
            // lblIsDynamic
            // 
            this.lblIsDynamic.AutoSize = true;
            this.lblIsDynamic.Location = new System.Drawing.Point(26, 123);
            this.lblIsDynamic.Name = "lblIsDynamic";
            this.lblIsDynamic.Size = new System.Drawing.Size(56, 13);
            this.lblIsDynamic.TabIndex = 10;
            this.lblIsDynamic.Text = "IsDynamic";
            // 
            // lblImageRuntimeVersion
            // 
            this.lblImageRuntimeVersion.AutoSize = true;
            this.lblImageRuntimeVersion.Location = new System.Drawing.Point(26, 94);
            this.lblImageRuntimeVersion.Name = "lblImageRuntimeVersion";
            this.lblImageRuntimeVersion.Size = new System.Drawing.Size(110, 13);
            this.lblImageRuntimeVersion.TabIndex = 9;
            this.lblImageRuntimeVersion.Text = "ImageRuntimeVersion";
            // 
            // lblEntryPoint
            // 
            this.lblEntryPoint.AutoSize = true;
            this.lblEntryPoint.Location = new System.Drawing.Point(26, 70);
            this.lblEntryPoint.Name = "lblEntryPoint";
            this.lblEntryPoint.Size = new System.Drawing.Size(55, 13);
            this.lblEntryPoint.TabIndex = 8;
            this.lblEntryPoint.Text = "EntryPoint";
            // 
            // lblCodebase
            // 
            this.lblCodebase.AutoSize = true;
            this.lblCodebase.Location = new System.Drawing.Point(26, 46);
            this.lblCodebase.Name = "lblCodebase";
            this.lblCodebase.Size = new System.Drawing.Size(55, 13);
            this.lblCodebase.TabIndex = 7;
            this.lblCodebase.Text = "Codebase";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(26, 21);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(51, 13);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "FullName";
            // 
            // FrmAssemblyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 200);
            this.Controls.Add(this.lblIsFullyTrusted);
            this.Controls.Add(this.lblIsDynamic);
            this.Controls.Add(this.lblImageRuntimeVersion);
            this.Controls.Add(this.lblEntryPoint);
            this.Controls.Add(this.lblCodebase);
            this.Controls.Add(this.lblFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAssemblyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assembly Info";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAssemblyInfo_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsFullyTrusted;
        private System.Windows.Forms.Label lblIsDynamic;
        private System.Windows.Forms.Label lblImageRuntimeVersion;
        private System.Windows.Forms.Label lblEntryPoint;
        private System.Windows.Forms.Label lblCodebase;
        private System.Windows.Forms.Label lblFullName;
    }
}