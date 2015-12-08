using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Security.Cryptography;

namespace GetLicFromFile
{
    public partial class FormGetLicFromFile : Form
    {
        public FormGetLicFromFile()
        {
            InitializeComponent();
        }

        private void buttonGetLicFromFile_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            //xdoc.Load("c:\\test\\LicenseSystem\\lic.xml");
            xdoc.Load("C:\\src\\Inteli-Phone-Book\\InteliPhoneBook\\InteliPhoneBookService\\bin\\Debug\\lic.xml");

            listBoxGetLicFromFile.Items.Add(xdoc.DocumentElement["type"].InnerText);
            listBoxGetLicFromFile.Items.Add(xdoc.DocumentElement["endpoint"].InnerText);
            listBoxGetLicFromFile.Items.Add(xdoc.DocumentElement["createtime"].InnerText);
            listBoxGetLicFromFile.Items.Add(xdoc.DocumentElement["endtime"].InnerText);
            XmlElement elem = (XmlElement)xdoc.DocumentElement["features"].FirstChild;
            int nFeatures = xdoc.DocumentElement["features"].GetElementsByTagName("feature").Count;
            for (int i = 0; i < nFeatures; i++)
            {
                listBoxGetLicFromFile.Items.Add(elem.Attributes["name"].Value + ":" + elem.Attributes["value"].Value);
                elem = (XmlElement)elem.NextSibling;
            }
            listBoxGetLicFromFile.Items.Add("signature:" + xdoc.DocumentElement["signature"].InnerText);
        }

        private void buttonCreateSignature_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            //xdoc.Load("c:\\test\\LicenseSystem\\lic.xml");
            xdoc.Load("C:\\src\\Inteli-Phone-Book\\InteliPhoneBook\\InteliPhoneBookService\\bin\\Debug\\lic.xml");
            SHA384Managed shaM = new SHA384Managed();
            byte[] data;

            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write(12);
            bw.Write(xdoc.DocumentElement["level"].InnerText);
            bw.Write(xdoc.DocumentElement["type"].InnerText);
            bw.Write(xdoc.DocumentElement["endpoint"].InnerText);
            bw.Write(xdoc.DocumentElement["createtime"].InnerText);
            bw.Write(xdoc.DocumentElement["endtime"].InnerText);
            bw.Write(xdoc.DocumentElement["guid"].InnerText);
            XmlElement elem = (XmlElement)xdoc.DocumentElement["features"].FirstChild;
            int nFeatures = xdoc.DocumentElement["features"].GetElementsByTagName("feature").Count;
            for (int i = 0; i < nFeatures; i++)
            {
                bw.Write(elem.Attributes["name"].Value);bw.Write(elem.Attributes["value"].Value);
                elem = (XmlElement)elem.NextSibling;
            }
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
            listBoxGetLicFromFile.Items.Add("Signature:" + result);
            textBoxSignature.Text = result;
        }
    }
}
