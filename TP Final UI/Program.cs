using log4net;
using Quartz;
using Quartz.Impl;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final.Jobs;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace TP_Final_UI
{

    static class Program
    {
        //El log se guarda en .\Log.txt
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        ///  Entrada principal de la aplicacion
        /// </summary>
        [STAThread]
        static void Main()
        {

            log.Info("----------App Iniciada----------");
            Task.Run(() => InitialzeScheduler());
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaLogin());
        }

        private static async Task InitialzeScheduler()
        {
            // construct a scheduler factory using defaults
            StdSchedulerFactory factory = new StdSchedulerFactory();

            // get a scheduler
            IScheduler scheduler = await factory.GetScheduler();
            await scheduler.Start();

            // define the job and tie it to our ReportePorVencerJob class
            IJobDetail reportePorVencerJob = JobBuilder.Create<ReportePorVencerJob>()
                .WithIdentity("ReportePorVencerJob", "group1")
                .Build();

            IJobDetail notificacionJob = JobBuilder.Create<NotificacionJob>()
                .WithIdentity("NotificacionJob", "group1")
                .Build();

            // Trigger the job to run now, and then every 24 hours
            ITrigger CadaDiaTrigger1 = TriggerBuilder.Create()
                .WithIdentity("Cada24HorasreportePorVencerTrigger", "group1")
                .StartNow()
                .WithSimpleSchedule(x => x
                    .WithIntervalInHours(24)
                    .RepeatForever())
            .Build();

            ITrigger CadaDiaTrigger2 = TriggerBuilder.Create()
                .WithIdentity("Cada24HorasnotificacionJob", "group1")
                .StartNow()
                .WithSimpleSchedule(x => x
                    .WithIntervalInHours(24)
                    .RepeatForever())
            .Build();

            await scheduler.ScheduleJob(reportePorVencerJob, CadaDiaTrigger1);
            //await scheduler.ScheduleJob(notificacionJob, CadaDiaTrigger2);
        }
    }
}
