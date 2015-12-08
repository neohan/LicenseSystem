namespace GetLicFromFile
{
    partial class FormGetLicFromFile
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxGetLicFromFile = new System.Windows.Forms.ListBox();
            this.buttonGetLicFromFile = new System.Windows.Forms.Button();
            this.buttonCreateSignature = new System.Windows.Forms.Button();
            this.textBoxSignature = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxGetLicFromFile
            // 
            this.listBoxGetLicFromFile.FormattingEnabled = true;
            this.listBoxGetLicFromFile.ItemHeight = 12;
            this.listBoxGetLicFromFile.Location = new System.Drawing.Point(12, 12);
            this.listBoxGetLicFromFile.Name = "listBoxGetLicFromFile";
            this.listBoxGetLicFromFile.Size = new System.Drawing.Size(855, 280);
            this.listBoxGetLicFromFile.TabIndex = 0;
            // 
            // buttonGetLicFromFile
            // 
            this.buttonGetLicFromFile.Location = new System.Drawing.Point(12, 306);
            this.buttonGetLicFromFile.Name = "buttonGetLicFromFile";
            this.buttonGetLicFromFile.Size = new System.Drawing.Size(89, 23);
            this.buttonGetLicFromFile.TabIndex = 1;
            this.buttonGetLicFromFile.Text = "Get";
            this.buttonGetLicFromFile.UseVisualStyleBackColor = true;
            this.buttonGetLicFromFile.Click += new System.EventHandler(this.buttonGetLicFromFile_Click);
            // 
            // buttonCreateSignature
            // 
            this.buttonCreateSignature.Location = new System.Drawing.Point(738, 307);
            this.buttonCreateSignature.Name = "buttonCreateSignature";
            this.buttonCreateSignature.Size = new System.Drawing.Size(129, 22);
            this.buttonCreateSignature.TabIndex = 2;
            this.buttonCreateSignature.Text = "Create Signature";
            this.buttonCreateSignature.UseVisualStyleBackColor = true;
            this.buttonCreateSignature.Click += new System.EventHandler(this.buttonCreateSignature_Click);
            // 
            // textBoxSignature
            // 
            this.textBoxSignature.Location = new System.Drawing.Point(118, 308);
            this.textBoxSignature.Name = "textBoxSignature";
            this.textBoxSignature.Size = new System.Drawing.Size(614, 21);
            this.textBoxSignature.TabIndex = 3;
            // 
            // FormGetLicFromFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 341);
            this.Controls.Add(this.textBoxSignature);
            this.Controls.Add(this.buttonCreateSignature);
            this.Controls.Add(this.buttonGetLicFromFile);
            this.Controls.Add(this.listBoxGetLicFromFile);
            this.Name = "FormGetLicFromFile";
            this.Text = "Get Lic From File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGetLicFromFile;
        private System.Windows.Forms.Button buttonGetLicFromFile;
        private System.Windows.Forms.Button buttonCreateSignature;
        private System.Windows.Forms.TextBox textBoxSignature;
    }
}

