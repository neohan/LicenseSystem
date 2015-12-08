namespace GetMacId
{
    partial class FormGetMACID
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
            this.labelGetMacId = new System.Windows.Forms.Label();
            this.buttonGetMacID = new System.Windows.Forms.Button();
            this.textBoxMacId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mac ID";
            // 
            // labelGetMacId
            // 
            this.labelGetMacId.AutoSize = true;
            this.labelGetMacId.Location = new System.Drawing.Point(79, 9);
            this.labelGetMacId.Name = "labelGetMacId";
            this.labelGetMacId.Size = new System.Drawing.Size(0, 12);
            this.labelGetMacId.TabIndex = 1;
            // 
            // buttonGetMacID
            // 
            this.buttonGetMacID.Location = new System.Drawing.Point(373, 9);
            this.buttonGetMacID.Name = "buttonGetMacID";
            this.buttonGetMacID.Size = new System.Drawing.Size(75, 23);
            this.buttonGetMacID.TabIndex = 2;
            this.buttonGetMacID.Text = "Get";
            this.buttonGetMacID.UseVisualStyleBackColor = true;
            this.buttonGetMacID.Click += new System.EventHandler(this.buttonGetMacID_Click);
            // 
            // textBoxMacId
            // 
            this.textBoxMacId.Location = new System.Drawing.Point(81, 27);
            this.textBoxMacId.Name = "textBoxMacId";
            this.textBoxMacId.Size = new System.Drawing.Size(267, 21);
            this.textBoxMacId.TabIndex = 3;
            // 
            // FormGetMACID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 51);
            this.Controls.Add(this.textBoxMacId);
            this.Controls.Add(this.buttonGetMacID);
            this.Controls.Add(this.labelGetMacId);
            this.Controls.Add(this.label1);
            this.Name = "FormGetMACID";
            this.Text = "Get MAC ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGetMacId;
        private System.Windows.Forms.Button buttonGetMacID;
        private System.Windows.Forms.TextBox textBoxMacId;
    }
}

