namespace GenerateProjectKey
{
    partial class GenerateProjectInsideKeyForm
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
            this.buttonGenerateProjectKey = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxInsideProjectKey = new System.Windows.Forms.TextBox();
            this.textBoxDecrypt = new System.Windows.Forms.TextBox();
            this.textBoxEncrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerateProjectKey
            // 
            this.buttonGenerateProjectKey.Location = new System.Drawing.Point(721, 176);
            this.buttonGenerateProjectKey.Name = "buttonGenerateProjectKey";
            this.buttonGenerateProjectKey.Size = new System.Drawing.Size(176, 26);
            this.buttonGenerateProjectKey.TabIndex = 0;
            this.buttonGenerateProjectKey.Text = "Generate Project Key";
            this.buttonGenerateProjectKey.UseVisualStyleBackColor = true;
            this.buttonGenerateProjectKey.Click += new System.EventHandler(this.buttonGenerateProjectKey_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inside Project Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Outside Project Key";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(147, 12);
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(846, 21);
            this.textBoxOriginal.TabIndex = 3;
            // 
            // textBoxInsideProjectKey
            // 
            this.textBoxInsideProjectKey.Location = new System.Drawing.Point(147, 143);
            this.textBoxInsideProjectKey.Name = "textBoxInsideProjectKey";
            this.textBoxInsideProjectKey.Size = new System.Drawing.Size(846, 21);
            this.textBoxInsideProjectKey.TabIndex = 4;
            // 
            // textBoxDecrypt
            // 
            this.textBoxDecrypt.Location = new System.Drawing.Point(147, 89);
            this.textBoxDecrypt.Name = "textBoxDecrypt";
            this.textBoxDecrypt.Size = new System.Drawing.Size(846, 21);
            this.textBoxDecrypt.TabIndex = 5;
            // 
            // textBoxEncrypt
            // 
            this.textBoxEncrypt.Location = new System.Drawing.Point(147, 62);
            this.textBoxEncrypt.Name = "textBoxEncrypt";
            this.textBoxEncrypt.Size = new System.Drawing.Size(846, 21);
            this.textBoxEncrypt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encrypt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Decrypt";
            // 
            // GenerateProjectInsideKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 214);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEncrypt);
            this.Controls.Add(this.textBoxDecrypt);
            this.Controls.Add(this.textBoxInsideProjectKey);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerateProjectKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GenerateProjectInsideKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Project Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateProjectKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxInsideProjectKey;
        private System.Windows.Forms.TextBox textBoxDecrypt;
        private System.Windows.Forms.TextBox textBoxEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

