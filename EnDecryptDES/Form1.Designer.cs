namespace EnDecryptDES
{
    partial class FormEnDecryptDES
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
            this.textBoxOriginalString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEncryptedString = new System.Windows.Forms.Label();
            this.abel3 = new System.Windows.Forms.Label();
            this.labelDecryptedString = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxEncryptedString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Content";
            // 
            // textBoxOriginalString
            // 
            this.textBoxOriginalString.Location = new System.Drawing.Point(117, 6);
            this.textBoxOriginalString.Name = "textBoxOriginalString";
            this.textBoxOriginalString.Size = new System.Drawing.Size(501, 21);
            this.textBoxOriginalString.TabIndex = 1;
            this.textBoxOriginalString.Text = "helloworldksdlkijuneauguest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted String";
            // 
            // labelEncryptedString
            // 
            this.labelEncryptedString.AutoSize = true;
            this.labelEncryptedString.Location = new System.Drawing.Point(119, 46);
            this.labelEncryptedString.Name = "labelEncryptedString";
            this.labelEncryptedString.Size = new System.Drawing.Size(0, 12);
            this.labelEncryptedString.TabIndex = 3;
            // 
            // abel3
            // 
            this.abel3.AutoSize = true;
            this.abel3.Location = new System.Drawing.Point(12, 90);
            this.abel3.Name = "abel3";
            this.abel3.Size = new System.Drawing.Size(101, 12);
            this.abel3.TabIndex = 4;
            this.abel3.Text = "Decrypted String";
            // 
            // labelDecryptedString
            // 
            this.labelDecryptedString.AutoSize = true;
            this.labelDecryptedString.Location = new System.Drawing.Point(119, 90);
            this.labelDecryptedString.Name = "labelDecryptedString";
            this.labelDecryptedString.Size = new System.Drawing.Size(0, 12);
            this.labelDecryptedString.TabIndex = 5;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(434, 135);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypt.TabIndex = 6;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(543, 135);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxEncryptedString
            // 
            this.textBoxEncryptedString.Location = new System.Drawing.Point(117, 66);
            this.textBoxEncryptedString.Name = "textBoxEncryptedString";
            this.textBoxEncryptedString.Size = new System.Drawing.Size(501, 21);
            this.textBoxEncryptedString.TabIndex = 8;
            // 
            // FormEnDecryptDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 166);
            this.Controls.Add(this.textBoxEncryptedString);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.labelDecryptedString);
            this.Controls.Add(this.abel3);
            this.Controls.Add(this.labelEncryptedString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOriginalString);
            this.Controls.Add(this.label1);
            this.Name = "FormEnDecryptDES";
            this.Text = "En- Decrypt DES";
            this.Load += new System.EventHandler(this.FormEnDecryptDES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOriginalString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEncryptedString;
        private System.Windows.Forms.Label abel3;
        private System.Windows.Forms.Label labelDecryptedString;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxEncryptedString;
    }
}

