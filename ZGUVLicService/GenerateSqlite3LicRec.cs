using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace ZGUVLicService
{
    class GenerateSqlite3LicRec
    {
        private static byte[] ProjectInsideKeys = { 0xAA, 0xDF, 0x29, 0x5C, 0x36, 0x90, 0x17, 0x68 };
        private static string ProjectInsideAddKey = "projectINSIDEkey";
        private static byte[] Keys = { 0xA5, 0x95, 0x6E, 0x44, 0x80, 0xCB, 0x8F, 0x77 };
        private static string AddKey = "";

        static public log4net.ILog log = log4net.LogManager.GetLogger("gelic");
        static public GenerateSqlite3LicRec GenerateSqlite3LicRecObj = null;
        SQLiteConnection sqliteconn = new SQLiteConnection();


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

        string DecryptDES_ProjectInsideKey(string decryptString, string decryptKey)
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

        private string EncryptDES_ProjectInsideKey(string encryptString, string encryptKey)
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

        string DecryptDES(string decryptString, string decryptKey)
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

        void LoadLicFile(out string p_monitorExts)
        {
            string thisEndpointKey = EncryptDES_ProjectInsideKey(String.Format("{0}-{1}-{2}", GetCpuId(), GetDiskId(), GetMacId()), "35405717");
            p_monitorExts = "0";
            string versiontypestr = "";
            XmlDocument xdoc = new XmlDocument();
            try
            {
                int pos = Application.ExecutablePath.LastIndexOf("\\");
                string path = Application.ExecutablePath.Substring(0, pos);
                xdoc.Load(path + "\\lic.xml");
            }
            catch (Exception ex)
            {
                log.Info(String.Format("invalid lic.\r\n{0}", ex.Message));
                return;
            }

            //verification
            try
            {
                string endpoint = xdoc.DocumentElement["endpoint"].InnerText;
                if (endpoint != thisEndpointKey)
                {
                    log.Info(String.Format("invalid lic.machine info is wrong.\r\nresult   :{0}\r\nsignature:{1}", thisEndpointKey, endpoint));
                    return;
                }
                AddKey = DecryptDES_ProjectInsideKey(endpoint, "35405717");

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
                    bw.Write(elem.Attributes["name"].Value); bw.Write(elem.Attributes["value"].Value);
                    if (elem.Attributes["name"].Value == "monitors")
                        p_monitorExts = DecryptDES(elem.Attributes["value"].Value, "35405717");
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
                string signature = xdoc.DocumentElement["signature"].InnerText;
                if (signature != result)
                {
                    log.Info(String.Format("invalid lic.signature is wrong.\r\nresult   :{0}\r\nsignature:{1}", result, signature));
                    return;
                }
            }
            catch (Exception ex)
            {
                log.Info(String.Format("invalid lic info.\r\n{0}", ex.Message));
                return;
            }


            if (versiontypestr == "basic")//SJ966WcqFE8=
            {
                log.Info("basic lic mode." + thisEndpointKey);
            }
            else if (versiontypestr == "enforce")//RH2ah1pD+oo=
            {
                log.Info("enforce lic mode." + thisEndpointKey);
            }
            else if (versiontypestr == "custom")//EpeEkWdlzb4=
            {
                log.Info("custom lic mode." + thisEndpointKey);
            }
            else
            {
                log.Info("invalid lic." + versiontypestr + "." + thisEndpointKey);
            }
        }

        public void Initialize()
        {
        }

        static public void DoWork(Object stateInfo)
        {
            bool bdbopened = false;
            log.Info("Generate Sqlite3 License Record Thread Starting...");
            GenerateSqlite3LicRec generateSqlite3LicRec = (GenerateSqlite3LicRec)stateInfo;
            GenerateSqlite3LicRec.GenerateSqlite3LicRecObj = generateSqlite3LicRec;
            generateSqlite3LicRec.Initialize();
            ShareMemory shareMem = new ShareMemory();
            while (true)
            {
                //启动共享内存
                //运行过程中不用再去检查共享内存，因为一旦被创建除非明确关闭，共享内存是一直存在的
                if ( shareMem.IsInited() == false )
                {
                    int ret = shareMem.Init("ED8753D8-05F1-4CD4-A966-225CE47A203EZGUVWILCOM");
                    if ( ret == 0 )
                        log.Info("Shared memory created.\r\n");
                    else
                    {
                        log.Info(String.Format("Create shared memory failure. return code:{0}\r\n", ret));
                        Thread.Sleep(5000);
                        continue;
                    }
                }

                //读许可配置文件。本服务程序与zguv服务程序部署在同一个目录下。
                string monitorExts;
                int nMonitorExts;
                generateSqlite3LicRec.LoadLicFile(out monitorExts);
                try { nMonitorExts = Convert.ToInt32(monitorExts); }catch(Exception e){nMonitorExts = 0;}

                //访问sqlite3数据库，写入数据
                if ( bdbopened == false )
                {
                    string file = "";
                    try
                    {
                        int pos = Application.ExecutablePath.LastIndexOf("\\");
                        string path = Application.ExecutablePath.Substring(0, pos);
                        file = String.Format("Data Source={0}\\zguv.db", path);
                        generateSqlite3LicRec.sqliteconn.ConnectionString = file;
                        generateSqlite3LicRec.sqliteconn.Open();
                        bdbopened = true;
                        log.Info(String.Format("Open file:{0} suc.\r\n", file));
                    }
                    catch (Exception e)
                    {
                        log.Info(String.Format("Open file:{0} failure.{1}\r\n", file, e.Message()));
                        bdbopened = false;
                        Thread.Sleep(5000);
                        continue;
                    }

                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("SELECT * FROM systemoptions WHERE name = \'MONITOR_DEVICES\'");
                    DataSet sysOptionsds = null;
                    try
                    {
                        sysOptionsds = SQLiteHelper.Query(generateSqlite3LicRec.sqliteconn, strSql.ToString());
                    }
                    catch (Exception e)
                    {
                        log.Info(String.Format("Check systemoptions fatal. error:{0}", e.Message));
                        Thread.Sleep(5000);
                        continue;
                    }                        
                    DataTable sysOptionstbl = sysOptionsds.Tables[0];
                    if (sysOptionstbl.Rows.Count == 0)
                    {
                        string strInsertSql;
                        strInsertSql = String.Format("INSERT INTO systemoptions(name, value) VALUES(\'MONITOR_DEVICES\', \'{0}\')", nMonitorExts);
                        try
                        {
                            SQLiteHelper.ExecuteSql(generateSqlite3LicRec.sqliteconn, strInsertSql);
                        }
                        catch (Exception e)
                        {
                            log.Info(String.Format("Insert into systemoptions fatal. error:{0}", e.Message));
                        }
                    }
                    else
                    {
                        string strInsertSql;
                        strInsertSql = String.Format("UPDATE systemoptions SET value = \'{0}\' WHERE name = \'MONITOR_DEVICES\')", nMonitorExts);
                        try
                        {
                            SQLiteHelper.ExecuteSql(generateSqlite3LicRec.sqliteconn, strInsertSql);
                        }
                        catch (Exception e)
                        {
                            log.Info(String.Format("Update for systemoptions fatal. error:{0}", e.Message));
                        }
                    }
                }

                Thread.Sleep(1000);
            }
            log.Info("Generate Sqlite3 License Record Thread Exiting...");
        }
    }
}
