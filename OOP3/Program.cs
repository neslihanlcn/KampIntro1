using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
        //    IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        //    ihtiyacKrediManager.Hesapla();
        //    TasitKrediManager tasitKrediManager = new TasitKrediManager();
        //    tasitKrediManager.Hesapla();
        //    KonutKrediManager konutKrediManager = new KonutKrediManager();
        //    konutKrediManager.Hesapla();

            // bu yöntemlede aynı sonucu alırız aşağıdaki instancelerdede aynı sonucu alabiriz 
            IKrediManager  ihtiyacKrediManager = new IhtiyacKrediManager();
            // ihtiyacKrediManager.Hesapla(); BU KISIMLARI KALDIRIRIZ BASVURU YAP SINIFINDA YAZDIĞIMIZ İÇİN
            IKrediManager  tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            IKrediManager  konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // BU İKİ YÖNTEMLEDE AYNI SONUCU ALIRIZ BASE İNTERFACENİNİN AVANTAJIDIR
            // bu demek oluyorki interfacelerde implemente edilen classların referans numaralarını tutabilir
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            IKrediManager esnafKrediManager = new EsnafKrediManager(); // 1. yöntem
            

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap( esnafKrediManager ,new List<ILoggerService> {new DatabaseLoggerService (),new SmsLoggerService () } );
            // bu şekilde hangi kredi türün seçtiysek onun metodundaki işlemi gerçekleştirir
                                                              // bu kısım çok önemli base classlar sayesinde uzun uzun detay vermeden metodun içinden kredi türünü ve loglama çeşidi seçebiliyoruz bu sayede hata vermez
                                                              // yazılımda sürdürülebilirliği sağlar.
                                                              // çağırılan metodun içinede newleyerek dahil edebiliriz- 2. yöntem
                                                              //new SmsLoggerService () - bu kısımı iptal ederiz liste log açtığımız için çoğul alır

            // listeye yeni seçenekler eklendiğinde de büyük avantaj sağlar bu yöntem yeni eklenen örneği sms log ve esnafkredisi örneğini incele
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler); loggger claslarından sonra iptal ettim
            // örnek: müşteri iki veyya daha fazla kredininde hesaplanmasını isterse bunuda yukarıdaki gibi bir eleman sayısı belirsiz bir
            // liste oluşturarak gerçekleştiririz ve basvuru yap clasından krediönbilendirmesiyap metodunu oluşturduk. içindeki foreach yapısı
            // her krediyi hesaplayarak gösterir
        }  
    }
}
