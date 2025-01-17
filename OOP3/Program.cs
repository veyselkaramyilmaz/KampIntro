﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileloggerService = new FileBaseLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerServices(), new FileBaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);


            List<IKrediManager> krediler = new List<IKrediManager>(){ihtiyacKrediManager, tasıtKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
