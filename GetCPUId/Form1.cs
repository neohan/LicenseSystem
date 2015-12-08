using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace GetCPUId
{
    public partial class FormGetCPUID : Form
    {
        public FormGetCPUID()
        {
            InitializeComponent();
        }

        private static string GetCpuId()
        {
            string strCpuid = "";
            try
            {
                ManagementClass mcCpu = new ManagementClass("win32_Processor");
                ManagementObjectCollection mocCpu = mcCpu.GetInstances();

                foreach (ManagementObject m in mocCpu)
                {
                    strCpuid = m["ProcessorId"].ToString();
                    if (strCpuid != null)
                    {
                        break;
                    }
                }

                return strCpuid;
            }
            catch
            {
                return strCpuid;
            }
        }

        private void buttonGetCPUID_Click(object sender, EventArgs e)
        {
            textBoxCPUId.Text = labelCPUID.Text = GetCpuId();
        }
    }
}
