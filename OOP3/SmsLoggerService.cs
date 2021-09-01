using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerService : ILoggerService   // ÖNEMLİ -İNTERFACE YAPISININ AVANTAJI- BASE SINIFIN, ALT SINIFLARINDA REFERANSINI TUTMASI BÜYÜK KOLAYLIK SAĞLAR
                                              // sisteme sonradan bu iki classı dahil edersek kodların içinde boğulmadan direk classları ekler
                                              // IkrediManager ve ILoggerservice base sınıflarını bu iki alt sınıfa impelemente ederek imza metodlarını kullanır
                                              // program.cs dende metodu çağırarak kolaylıkla yeni classlarda seçeneklerde ekleyebiliriz
    {
        public void Log()
        {
            Console.WriteLine("sms yollandı");
        }
    }
}
