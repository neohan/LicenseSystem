using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace ZGUVLicService
{
    public partial class ZGUVLicService : ServiceBase
    {
        static public log4net.ILog log = log4net.LogManager.GetLogger("root");
        public ZGUVLicService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            GenerateSqlite3LicRec GenerateSqlite3LicRec = new GenerateSqlite3LicRec();
            Thread Thread_sms = new Thread(new ParameterizedThreadStart(GenerateSqlite3LicRec.DoWork));
            Thread_sms.Start(GenerateSqlite3LicRec);
        }

        protected override void OnStop()
        {
        }
    }
}
