using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ZGUVLicService
{
    class GenerateSqlite3LicRec
    {
        static public log4net.ILog log = log4net.LogManager.GetLogger("gelic");
        static public GenerateSqlite3LicRec GenerateSqlite3LicRecObj = null;

        public void Initialize()
        {
        }

        static public void DoWork(Object stateInfo)
        {
            log.Info("Generate Sqlite3 License Record Thread Starting...");
            GenerateSqlite3LicRec generateSqlite3LicRec = (GenerateSqlite3LicRec)stateInfo;
            GenerateSqlite3LicRec.GenerateSqlite3LicRecObj = generateSqlite3LicRec;
            generateSqlite3LicRec.Initialize();
            while (true)
            {
                Thread.Sleep(1000);
            }
            log.Info("Generate Sqlite3 License Record Thread Exiting...");
        }
    }
}
