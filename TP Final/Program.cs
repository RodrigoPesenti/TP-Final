using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using TP_Final.API;
using TP_Final.DAL;
using TP_Final.DAL.EntityFramework;
using TP_Final.Domain;
using TP_Final.IO;
using TP_Final.Jobs;
using log4net;
using log4net.Config;
using System.IO;
using System.Configuration;
using TP_Final.Excepciones;
using TP_Final.IO.RequestDTO;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace TP_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }       
    }
}
