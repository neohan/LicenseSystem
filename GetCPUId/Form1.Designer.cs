namespace GetCPUId
{
    partial class FormGetCPUID
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
            this.labelCPUID = new System.Windows.Forms.Label();
            this.buttonGetCPUID = new System.Windows.Forms.Button();
            this.textBoxCPUId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU ID";
            // 
            // labelCPUID
            // 
            this.labelCPUID.AutoSize = true;
            this.labelCPUID.Location = new System.Drawing.Point(83, 9);
            this.labelCPUID.Name = "labelCPUID";
            this.labelCPUID.Size = new System.Drawing.Size(0, 12);
            this.labelCPUID.TabIndex = 1;
            // 
            // buttonGetCPUID
            // 
            this.buttonGetCPUID.Location = new System.Drawing.Point(425, 12);
            this.buttonGetCPUID.Name = "buttonGetCPUID";
            this.buttonGetCPUID.Size = new System.Drawing.Size(75, 23);
            this.buttonGetCPUID.TabIndex = 2;
            this.buttonGetCPUID.Text = "Get";
            this.buttonGetCPUID.UseVisualStyleBackColor = true;
            this.buttonGetCPUID.Click += new System.EventHandler(this.buttonGetCPUID_Click);
            // 
            // textBoxCPUId
            // 
            this.textBoxCPUId.Location = new System.Drawing.Point(75, 24);
            this.textBoxCPUId.Name = "textBoxCPUId";
            this.textBoxCPUId.Size = new System.Drawing.Size(295, 21);
            this.textBoxCPUId.TabIndex = 3;
            // 
            // FormGetCPUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 51);
            this.Controls.Add(this.textBoxCPUId);
            this.Controls.Add(this.buttonGetCPUID);
            this.Controls.Add(this.labelCPUID);
            this.Controls.Add(this.label1);
            this.Name = "FormGetCPUID";
            this.Text = "Get CPU ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCPUID;
        private System.Windows.Forms.Button buttonGetCPUID;
        private System.Windows.Forms.TextBox textBoxCPUId;
    }
}

