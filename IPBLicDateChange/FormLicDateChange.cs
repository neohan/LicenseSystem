using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IPBLicDateChange
{
    public partial class FmIPBLicDataChange : Form
    {
        public FmIPBLicDataChange()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            int pos = Application.ExecutablePath.LastIndexOf("\\");
            string path = Application.ExecutablePath.Substring(0, pos);
            string file = String.Format("{0}\\InteliPhoneBookService.exe", path);
            DateTime now = DateTime.Now;
            File.SetCreationTime(file, now);
        }
    }
}
