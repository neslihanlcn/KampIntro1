using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {   // ilk başta müşteri clasına ait özellikler gibi dursada soyutlama tekniğine uymaz ve ilerde sorun oluşturabilir
        // bu yüzden gerçek ve tüzel kişi olarak iki ayrı class oluşturup asıl özellikleri oralara dağıttık
        public int Id { get; set; }  // bu iki özellik tuzel ve gerçek müşterinin ortak özelliği olduğu için base sınıfta yer alır böylece kendimizi tekrar etmeyiz
        public string   MusteriNo { get; set; }
        //public string  Adi { get; set; }
        //public string  Soyadi { get; set; }
        //public string SirketAdi { get; set; } gerçek bir kişi ile ilgili değildir o yüzden bu özellik bu kısımda yer almaz soyutlamaya ters düşen hatadır
         // tüzel müşteride yer alır tüzel müşterinin asıl özelliğidir 
        //public string   TcNo { get; set; }
        //public string VergiNo { get; set; }
    }
}
