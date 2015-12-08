using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;
using System.IO;

namespace GenerateInteliPhoneBookLicense
{
    public partial class FormGenerateIPBLic : Form
    {
        private static byte[] ProjectOutsideKeys = { 0x5A, 0x49, 0x36, 0x93, 0xA1, 0xCB, 0x8B, 0x2E };
        private static string ProjectOutsideAddKey = "projectOUTSIDEkey";
        private static byte[] ProjectInsideKeys = { 0xAA, 0xDF, 0x29, 0x5C, 0x36, 0x90, 0x17, 0x68 };
        private static string ProjectInsideAddKey = "projectINSIDEkey";
        private static byte[] Keys = { 0xA5, 0x95, 0x6E, 0x44, 0x80, 0xCB, 0x8F, 0x77 };
        private static string AddKey = "";

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

        private static string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                if (encryptKey.Length < 8)
                {
                    encryptKey += AddKey;
                }

                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));

                byte[] rgbIV = Keys;

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

        private static string DecryptDES(string decryptString, string decryptKey)
        {
            try
            {
                if (decryptKey.Length < 8)
                {
                    decryptKey += AddKey;
                }
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey.Substring(0, 8));

                byte[] rgbIV = Keys;

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

        public FormGenerateIPBLic()
        {
            InitializeComponent();
        }

        bool CreateInteliPhoneBookLicenseFile(string p_licMode, int p_sipTrunks)
        {
            XmlDocument xmlDoc = new XmlDocument();
            SHA384Managed shaM = new SHA384Managed();
            byte[] data;

            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write(12);

            XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(xmlDec);

            XmlElement xmlelem = xmlDoc.CreateElement("license");
            xmlDoc.AppendChild(xmlelem);
            XmlNode root = xmlDoc.SelectSingleNode("license");

            XmlElement xe_level = xmlDoc.CreateElement("level");
            xe_level.InnerText = EncryptDES("1", "35405717");
            root.AppendChild(xe_level);
            bw.Write(xe_level.InnerText);

            XmlElement xe_type = xmlDoc.CreateElement("type");
            xe_type.InnerText = EncryptDES("DAIRUPENG-FREESWITCH-INTELIPHONEBOOK", "35405717");
            root.AppendChild(xe_type);
            bw.Write(xe_type.InnerText);

            XmlElement xe_endpoint = xmlDoc.CreateElement("endpoint");
            xe_endpoint.InnerText = AddKey;
            root.AppendChild(xe_endpoint);
            bw.Write(xe_endpoint.InnerText);

            XmlElement xe_createtime = xmlDoc.CreateElement("createtime");
            xe_createtime.InnerText = EncryptDES(DateTime.Now.ToString(), "35405717");
            root.AppendChild(xe_createtime);
            bw.Write(xe_createtime.InnerText);

            XmlElement xe_endtime = xmlDoc.CreateElement("endtime");
            xe_endtime.InnerText = EncryptDES("2099-12-31", "35405717");
            root.AppendChild(xe_endtime);
            bw.Write(xe_endtime.InnerText);

            XmlElement xe_guid = xmlDoc.CreateElement("guid");
            xe_guid.InnerText = EncryptDES(System.Guid.NewGuid().ToString("D"), "35405717");
            root.AppendChild(xe_guid);
            bw.Write(xe_guid.InnerText);

            XmlElement features_xe = xmlDoc.CreateElement("features");

            XmlElement cardno_xe = xmlDoc.CreateElement("feature");
            cardno_xe.SetAttribute("name", "versiontype");
            cardno_xe.SetAttribute("value", EncryptDES(p_licMode, "35405717"));
            features_xe.AppendChild(cardno_xe);
            bw.Write("versiontype"); bw.Write(EncryptDES(p_licMode, "35405717"));

            XmlElement channel_xe = xmlDoc.CreateElement("feature");
            channel_xe.SetAttribute("name", "siptrunk");
            channel_xe.SetAttribute("value", EncryptDES(p_sipTrunks.ToString(), "35405717"));
            features_xe.AppendChild(channel_xe);
            bw.Write("siptrunk"); bw.Write(EncryptDES(p_sipTrunks.ToString(), "35405717"));

            root.AppendChild(features_xe);

            int nLen = (int)ms.Position + 1;
            bw.Close();
            ms.Close();
            data = ms.GetBuffer();
            data = shaM.ComputeHash(data, 0, nLen);
            string result = "";
            foreach (byte dbyte in data)
            {
                result += dbyte.ToString("X2");
            }

            XmlElement xe_signature = xmlDoc.CreateElement("signature");
            xe_signature.InnerText = result;
            root.AppendChild(xe_signature);

            DialogResult dialogResult = saveFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
                xmlDoc.Save(saveFileDialog1.FileName);
            return true;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                XmlDocument xdoc = new XmlDocument();
                try { xdoc.Load(openFileDialog1.FileName); }catch(Exception ex){return;}
                listBoxLog.Items.Add(xdoc.InnerXml);

                XmlNode root = xdoc.SelectSingleNode("machineinfo");
                if (root != null && root.Name == "machineinfo")
                {
                    XmlNode endpointNode = root.FirstChild;
                    if (endpointNode.Name == "endpoint")
                    {
                        string projectOutsideKeyEncrypted = endpointNode.InnerText;

                        string originalEndpoint = DecryptDES_ProjectOutsideKey(projectOutsideKeyEncrypted, "35405717");
                        AddKey = EncryptDES_ProjectInsideKey(originalEndpoint, "35405717");

                        string licMode = "basic";
                        if (radioButtonBasicMode.Checked)
                            licMode = "basic";
                        else if (radioButtonEnforceMode.Checked)
                            licMode = "enforce";
                        else if (radioButtonCustomMode.Checked)
                            licMode = "custom";
                        int sipTrunks;
                        try { sipTrunks = Convert.ToInt16(textBoxSipTrunk.Text); }
                        catch (Exception ex) { listBoxLog.Items.Add("请输入正确的中继数。"); return; }
                        if ( CreateInteliPhoneBookLicenseFile(licMode, sipTrunks) )
                            listBoxLog.Items.Add("创建许可文件成功。");
                        else
                            listBoxLog.Items.Add("创建许可文件失败。");
                    }
                    else
                        listBoxLog.Items.Add("无效的许可文件。endpoint节不存在。");
                }
                else
                    listBoxLog.Items.Add("无效的许可文件。根节点不是machineinfo。");
            }
        }
    }
}
