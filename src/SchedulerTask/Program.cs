using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Quartz;
using Quartz.Impl;
using System.Threading;
using SchedulerTask.MailService;

namespace SchedulerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMailSent = false;
            while (Thread.CurrentThread.IsAlive)
            {
                if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
                {
                    if (!isMailSent)
                    {
                        MailServiceClient client = new MailServiceClient();
                        client.SendMail(ConfigurationManager.AppSettings["MAILING_LIST"], "<html><body>Test</body><html>");
                        isMailSent = true;
                    }
                    else
                    {
                        Thread.Sleep(43200000);
                    }
                }
                else
                {
                    isMailSent = false;
                    Thread.Sleep(43200000);
                }
            }

            //SchedulerJob test = new SchedulerJob();
            //test.Execute(null);

            //// construct a scheduler factory
            //ISchedulerFactory schedFact = new StdSchedulerFactory();

            //// get a scheduler
            //IScheduler sched = schedFact.GetScheduler();
            //sched.Start();

            //IJobDetail job = JobBuilder.Create<SchedulerJob>()
            // .WithIdentity("job1", "group1")
            // .Build();

            //ITrigger trigger = TriggerBuilder.Create()
            //.WithIdentity("trigger1", "group1")
            //.WithCronSchedule("0 45 17 ? * *")
            //.Build();

            //sched.ScheduleJob(job, trigger);
        }
    }
}
