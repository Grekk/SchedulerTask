using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Quartz;
using SchedulerTask.MailService;

namespace SchedulerTask
{
    class SchedulerJob: IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("EnterJob");
            MailServiceClient client = new MailServiceClient();
            client.SendMail(ConfigurationManager.AppSettings["MAILING_LIST"], "<html><body>Test</body><html>");
        }
    }
}
