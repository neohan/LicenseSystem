using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetGUID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxGUID32Char.Text = System.Guid.NewGuid().ToString("N");
            textBoxGUIDHyphenSplitter.Text = System.Guid.NewGuid().ToString("D");
            textBoxCurlyBracketHyphenSplitter.Text = System.Guid.NewGuid().ToString("B");
            textBoxParenthesesHyphenSplitter.Text = System.Guid.NewGuid().ToString("P");
        }
    }
}
