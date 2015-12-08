using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace GenerateProjectKey
{
    public partial class GenerateProjectInsideKeyForm : Form
    {
        private static byte[] ProjectOutsideKeys = { 0x5A, 0x49, 0x36, 0x93, 0xA1, 0xCB, 0x8B, 0x2E };
        private static string ProjectOutsideAddKey = "projectOUTSIDEkey";
        private static byte[] ProjectInsideKeys = { 0xAA, 0xDF, 0x29, 0x5C, 0x36, 0x90, 0x17, 0x68 };
        private static string ProjectInsideAddKey = "projectINSIDEkey";

        private static byte[] LicenseKeys = { 0xAF, 0x9C, 0xF6, 0x09, 0xE9, 0xDB, 0x77, 0x69 };
        private static string LicenseAddKey = "568868802";

        public GenerateProjectInsideKeyForm()
        {
            InitializeComponent();
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

        private static string DecryptDES_ProjectOutsideKey(string decryptString, string decryptKey)
        {

            try
            {
                if (decryptKey.Length < 8)
                {
                    decryptKey += ProjectOutsideAddKey;
                }
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey.Substring(0, 8));

                byte[] rgbIV = ProjectOutsideKeys;

                byte[] inputByteArray = Convert.FromBase64String(decryptString);

                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();

                MemoryStream mStream = new MemoryStream();

                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);

                cStream.Write(inputByteArray, 0, inputByteArray.Length);

                cStream.FlushFinalBlock();

                return Encoding.UTF8.GetString(mStream.ToArray());

            }
            catch
            {
                return decryptString;
            }
        }

        private static string EncryptDES_ProjectInsideKey(string encryptString, string encryptKey)
        {
            try
            {
                if (encryptKey.Length < 8)
                {
                    encryptKey += ProjectInsideAddKey;
                }

                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));

                byte[] rgbIV = ProjectInsideKeys;

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

        private static string DecryptDES_ProjectInsideKey(string decryptString, string decryptKey)
        {

            try
            {
                if (decryptKey.Length < 8)
                {
                    decryptKey += ProjectInsideAddKey;
                }
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey.Substring(0, 8));

                byte[] rgbIV = ProjectInsideKeys;

                byte[] inputByteArray = Convert.FromBase64String(decryptString);

                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();

                MemoryStream mStream = new MemoryStream();

                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);

                cStream.Write(inputByteArray, 0, inputByteArray.Length);

                cStream.FlushFinalBlock();

                return Encoding.UTF8.GetString(mStream.ToArray());

            }
            catch
            {
                return decryptString;
            }
        }

        private static string EncryptDES_LicenseKey(string encryptString, string encryptKey)
        {
            try
            {
                if (encryptKey.Length < 8)
                {
                    encryptKey += LicenseAddKey;
                }

                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));

                byte[] rgbIV = LicenseKeys;

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

        private static string DecryptDES_LicenseKey(string decryptString, string decryptKey)
        {

            try
            {
                if (decryptKey.Length < 8)
                {
                    decryptKey += LicenseAddKey;
                }
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey.Substring(0, 8));

                byte[] rgbIV = LicenseKeys;

                byte[] inputByteArray = Convert.FromBase64String(decryptString);

                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();

                MemoryStream mStream = new MemoryStream();

                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);

                cStream.Write(inputByteArray, 0, inputByteArray.Length);

                cStream.FlushFinalBlock();

                return Encoding.UTF8.GetString(mStream.ToArray());

            }
            catch
            {
                return decryptString;
            }
        }

        private void buttonGenerateProjectKey_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(openFileDialog1.FileName);

                XmlNode root = xdoc.SelectSingleNode("machineinfo");
                if (root.Name == "machineinfo")
                {
                    XmlNode endpointNode = root.FirstChild;
                    if (endpointNode.Name == "endpoint")
                    {
                        string projectKeyEncrypted = endpointNode.InnerText;

                        textBoxOriginal.Text = DecryptDES_ProjectOutsideKey(projectKeyEncrypted, "35405717");
                        textBoxEncrypt.Text = EncryptDES_ProjectInsideKey(textBoxOriginal.Text, "35405717");
                        textBoxDecrypt.Text = DecryptDES_ProjectInsideKey(textBoxEncrypt.Text, "35405717");
                    }
                }
            }
        }
    }
}
