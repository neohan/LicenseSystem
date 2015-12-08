using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Xml;
using System.Security.Cryptography;
using System.Management;

namespace GetDiskId
{
    public partial class FormGetDiskID : Form
    {
        public FormGetDiskID()
        {
            InitializeComponent();
        }

        private static string GetDiskId()
        {
            string diskId = "";

            try
            {
                ManagementObjectSearcher wmiSearcher = new ManagementObjectSearcher();

                wmiSearcher.Query = new SelectQuery("Win32_DiskDrive",
                                                    "",
                                                    new string[] { "PNPDeviceID" });
                ManagementObjectCollection myCollection = wmiSearcher.Get();
                ManagementObjectCollection.ManagementObjectEnumerator em =
                myCollection.GetEnumerator();
                em.MoveNext();
                ManagementBaseObject mo = em.Current;
                diskId = mo.Properties["PNPDeviceID"].Value.ToString().Trim();
                return diskId;
            }
            catch
            {
                return diskId;
            }
        }

        private void buttonGetDiskID_Click(object sender, EventArgs e)
        {
            textBoxDiskId.Text = labelDiskID.Text = GetDiskId();
        }
    }
}
