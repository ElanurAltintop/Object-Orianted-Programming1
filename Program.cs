using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
           // ıhtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
           // tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,databaseloggerService);
            basvuruManager.BasvuruYap(tasitKrediManager, fileloggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager, tasitKrediManager, konutKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); 
        }
    }
}
