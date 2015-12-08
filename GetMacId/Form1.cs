using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Management;

namespace GetMacId
{
    public partial class FormGetMACID : Form
    {
        public FormGetMACID()
        {
            InitializeComponent();
        }

        private static string GetMacId()
        {
            string macId = "";

            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    NetworkInterface[] ifaces = NetworkInterface.GetAllNetworkInterfaces();
                    PhysicalAddress address = ifaces[0].GetPhysicalAddress();
                    byte[] byteAddr = address.GetAddressBytes();
                    for (int i = 0; i < byteAddr.Length; i++)
                    {
                        macId += byteAddr[i].ToString("X2");
                        if (i != byteAddr.Length - 1)
                        {
                            macId += "-";
                        }
                    }
                }
                return macId;
            }
            catch
            {
                return macId;
            }
        }

        private void buttonGetMacID_Click(object sender, EventArgs e)
        {
            textBoxMacId.Text = labelGetMacId.Text = GetMacId();
        }
    }
}
