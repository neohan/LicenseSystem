namespace GetDiskId
{
    partial class FormGetDiskID
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelDiskID = new System.Windows.Forms.Label();
            this.buttonGetDiskID = new System.Windows.Forms.Button();
            this.textBoxDiskId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disk ID";
            // 
            // labelDiskID
            // 
            this.labelDiskID.AutoSize = true;
            this.labelDiskID.Location = new System.Drawing.Point(78, 9);
            this.labelDiskID.Name = "labelDiskID";
            this.labelDiskID.Size = new System.Drawing.Size(0, 12);
            this.labelDiskID.TabIndex = 1;
            // 
            // buttonGetDiskID
            // 
            this.buttonGetDiskID.Location = new System.Drawing.Point(451, 31);
            this.buttonGetDiskID.Name = "buttonGetDiskID";
            this.buttonGetDiskID.Size = new System.Drawing.Size(75, 23);
            this.buttonGetDiskID.TabIndex = 2;
            this.buttonGetDiskID.Text = "Get";
            this.buttonGetDiskID.UseVisualStyleBackColor = true;
            this.buttonGetDiskID.Click += new System.EventHandler(this.buttonGetDiskID_Click);
            // 
            // textBoxDiskId
            // 
            this.textBoxDiskId.Location = new System.Drawing.Point(14, 31);
            this.textBoxDiskId.Name = "textBoxDiskId";
            this.textBoxDiskId.Size = new System.Drawing.Size(404, 21);
            this.textBoxDiskId.TabIndex = 3;
            // 
            // FormGetDiskID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 66);
            this.Controls.Add(this.textBoxDiskId);
            this.Controls.Add(this.buttonGetDiskID);
            this.Controls.Add(this.labelDiskID);
            this.Controls.Add(this.label1);
            this.Name = "FormGetDiskID";
            this.Text = "Get DISK ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiskID;
        private System.Windows.Forms.Button buttonGetDiskID;
        private System.Windows.Forms.TextBox textBoxDiskId;
    }
}

