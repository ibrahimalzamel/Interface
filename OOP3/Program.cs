using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKerdiManager konutKerdiManager = new KonutKerdiManager();
            EsnafKredisiManager esnafKredisiManager = new EsnafKredisiManager();
            List<IKrediManager> krediler = new List<IKrediManager>() 
            {
                ihtiyacKrediManager,
                tasitKrediManager ,
                konutKerdiManager ,
                esnafKredisiManager
            };

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FilebaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> Loggers = new List<ILoggerService>() {
            databaseLoggerService,
            fileLoggerService,
            smsLoggerService
            };
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, Loggers);
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
