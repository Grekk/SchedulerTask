using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Quartz;
using Quartz.Impl;
using System.Threading;
using SchedulerTask.MailService;
using SchedulerTask.MoviesShowingService;

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
                        string url = ConfigurationManager.AppSettings["MOVIE_URL"];
                        string htmlContent = "<html><body><p>Voici la liste des films conseillés qui sortent aujourd'hui:</p><section>";

                        IMoviesShowingService movies = new MoviesShowingServiceClient();
                        IList<TinyMovie> movieList = movies.GetBestWeekMovies();
                        foreach (TinyMovie movie in movieList)
                        {
                            htmlContent += "<section style=\"width: 200px;height: 500px;float: left;padding: 10px;\">";
                            htmlContent += "<a href=\"" + url + movie.ApiId + "\"><img src=\"" + movie.PictureUrl + "\" height=\"193\" width=\"143\"/></a>";
                            htmlContent += "</section>";
                        }

                        htmlContent += "</section></body></html>";

                        MailServiceClient client = new MailServiceClient();

                        client.SendMail(ConfigurationManager.AppSettings["MAILING_LIST"], htmlContent);
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
