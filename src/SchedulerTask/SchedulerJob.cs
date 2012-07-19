using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;

namespace SchedulerTask
{
    class SchedulerJob: IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
