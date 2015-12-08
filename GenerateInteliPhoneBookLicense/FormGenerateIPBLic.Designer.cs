namespace GenerateInteliPhoneBookLicense
{
    partial class FormGenerateIPBLic
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCustomMode = new System.Windows.Forms.RadioButton();
            this.radioButtonEnforceMode = new System.Windows.Forms.RadioButton();
            this.radioButtonBasicMode = new System.Windows.Forms.RadioButton();
            this.textBoxSipTrunk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(828, 36);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.ItemHeight = 12;
            this.listBoxLog.Location = new System.Drawing.Point(12, 92);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(891, 184);
            this.listBoxLog.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "许可文件(*.xml)|*.xml";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCustomMode);
            this.groupBox1.Controls.Add(this.radioButtonEnforceMode);
            this.groupBox1.Controls.Add(this.radioButtonBasicMode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Licence Mode";
            // 
            // radioButtonCustomMode
            // 
            this.radioButtonCustomMode.AutoSize = true;
            this.radioButtonCustomMode.Location = new System.Drawing.Point(182, 20);
            this.radioButtonCustomMode.Name = "radioButtonCustomMode";
            this.radioButtonCustomMode.Size = new System.Drawing.Size(59, 16);
            this.radioButtonCustomMode.TabIndex = 2;
            this.radioButtonCustomMode.TabStop = true;
            this.radioButtonCustomMode.Text = "定制版";
            this.radioButtonCustomMode.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnforceMode
            // 
            this.radioButtonEnforceMode.AutoSize = true;
            this.radioButtonEnforceMode.Location = new System.Drawing.Point(100, 20);
            this.radioButtonEnforceMode.Name = "radioButtonEnforceMode";
            this.radioButtonEnforceMode.Size = new System.Drawing.Size(59, 16);
            this.radioButtonEnforceMode.TabIndex = 1;
            this.radioButtonEnforceMode.TabStop = true;
            this.radioButtonEnforceMode.Text = "增强版";
            this.radioButtonEnforceMode.UseVisualStyleBackColor = true;
            // 
            // radioButtonBasicMode
            // 
            this.radioButtonBasicMode.AutoSize = true;
            this.radioButtonBasicMode.Location = new System.Drawing.Point(16, 20);
            this.radioButtonBasicMode.Name = "radioButtonBasicMode";
            this.radioButtonBasicMode.Size = new System.Drawing.Size(59, 16);
            this.radioButtonBasicMode.TabIndex = 0;
            this.radioButtonBasicMode.TabStop = true;
            this.radioButtonBasicMode.Text = "基础版";
            this.radioButtonBasicMode.UseVisualStyleBackColor = true;
            // 
            // textBoxSipTrunk
            // 
            this.textBoxSipTrunk.Location = new System.Drawing.Point(390, 31);
            this.textBoxSipTrunk.Name = "textBoxSipTrunk";
            this.textBoxSipTrunk.Size = new System.Drawing.Size(172, 21);
            this.textBoxSipTrunk.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "中继数";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "许可文件(*.xml)|*.xml";
            // 
            // FormGenerateIPBLic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSipTrunk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "FormGenerateIPBLic";
            this.Text = "Generate InteliPhoneBook License";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCustomMode;
        private System.Windows.Forms.RadioButton radioButtonEnforceMode;
        private System.Windows.Forms.RadioButton radioButtonBasicMode;
        private System.Windows.Forms.TextBox textBoxSipTrunk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

