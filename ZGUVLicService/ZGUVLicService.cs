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
            Thread Thread_sms = new Thread(new ParameterizedThreadStart(SMSProcessor.DoWork));
            Thread_sms.Start(SMSProcessor);
        }

        protected override void OnStop()
        {
        }
    }
}
