using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CreateXMLFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CreateXML()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(xmlDec);

            XmlElement xmlelem = xmlDoc.CreateElement("license");
            xmlDoc.AppendChild(xmlelem);
            XmlNode root = xmlDoc.SelectSingleNode("license");

            XmlElement xe_level = xmlDoc.CreateElement("level");
            xe_level.InnerText = "1";
            root.AppendChild(xe_level);

            XmlElement xe_type = xmlDoc.CreateElement("type");
            xe_type.InnerText = "AVAYACTIRECORDER";
            root.AppendChild(xe_type);

            XmlElement xe_endpoint = xmlDoc.CreateElement("endpoint");
            xe_endpoint.InnerText = "0FEBFBFF00020655-";
            root.AppendChild(xe_endpoint);

            XmlElement xe_createtime = xmlDoc.CreateElement("createtime");
            xe_createtime.InnerText = "2015-01-01 16:07:51";
            root.AppendChild(xe_createtime);

            XmlElement xe_endtime = xmlDoc.CreateElement("endtime");
            xe_endtime.InnerText = "2055-01-01";
            root.AppendChild(xe_endtime);

            XmlElement xe_child1 = xmlDoc.CreateElement("guid");
            xe_child1.InnerText = "abc";
            root.AppendChild(xe_child1);

            XmlElement features_xe = xmlDoc.CreateElement("features");

            XmlElement cardno_xe = xmlDoc.CreateElement("feature");
            cardno_xe.SetAttribute("name", "versiontype");
            cardno_xe.SetAttribute("value", "8309404");
            features_xe.AppendChild(cardno_xe);

            XmlElement channel_xe = xmlDoc.CreateElement("feature");
            channel_xe.SetAttribute("name", "siptrunk");
            channel_xe.SetAttribute("value", "30");
            features_xe.AppendChild(channel_xe);
            
            root.AppendChild(features_xe);

            xmlDoc.Save(@"C:\test.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateXML();
        }
    }
}
