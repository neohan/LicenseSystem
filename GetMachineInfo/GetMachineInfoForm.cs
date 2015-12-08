using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.IO;

namespace GetMachineInfo
{
    public partial class GetMachineInfoForm : Form
    {
        private static byte[] ProjectOutsideKeys = { 0x5A, 0x49, 0x36, 0x93, 0xA1, 0xCB, 0x8B, 0x2E };
        private static string ProjectOutsideAddKey = "projectOUTSIDEkey";
        public GetMachineInfoForm()
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


        private static string EncryptDES_ProjectOutsideKey(string encryptString, string encryptKey)
        {
            try
            {
                if (encryptKey.Length < 8)
                {
                    encryptKey += ProjectOutsideAddKey;
                }

                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));

                byte[] rgbIV = ProjectOutsideKeys;

                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);

                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();

                MemoryStream mStream = new MemoryStream();

                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);

                cStream.Write(inputByteArray, 0, inputByteArray.Length);

                cStream.FlushFinalBlock();

                return Convert.ToBase64String(mStream.ToArray());

            }
            catch
            {
                return encryptString;
            }
        }

        public void CreateMachineInfoXML(string p_fileName, string p_endpointID)
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(xmlDec);

            XmlElement xmlelem = xmlDoc.CreateElement("machineinfo");
            xmlDoc.AppendChild(xmlelem);
            XmlNode root = xmlDoc.SelectSingleNode("machineinfo");

            XmlElement xe_endpoint = xmlDoc.CreateElement("endpoint");
            xe_endpoint.InnerText = p_endpointID;
            root.AppendChild(xe_endpoint);

            xmlDoc.Save(p_fileName);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string fileName = "";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                CreateMachineInfoXML(fileName, EncryptDES_ProjectOutsideKey(String.Format("{0}-{1}-{2}", GetCpuId(), GetDiskId(), GetMacId()), "35405717"));
            }
        }
    }
}
