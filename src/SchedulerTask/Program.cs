using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Quartz.Impl;

namespace SchedulerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // construct a scheduler factory
            ISchedulerFactory schedFact = new StdSchedulerFactory();

            // get a scheduler
            IScheduler sched = schedFact.GetScheduler();
            sched.Start();

            IJobDetail job = JobBuilder.Create<SchedulerJob>()
             .WithIdentity("job1", "group1")
             .Build();

            ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity("trigger1", "group1")
            .WithCronSchedule("0 20 17 ? * *")
            .Build();

            sched.ScheduleJob(job, trigger);
        }
    }
}
