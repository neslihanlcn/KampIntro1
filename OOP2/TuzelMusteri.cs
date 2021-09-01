using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TuzelMusteri : Musteri  // musterinin özelliklerini ve operasyonlarını bu alt sınıfta kullanmak istiyorsak miras inheritance kullanırız.
                                  // tüzel müşteride gerçek müşteride bir müşteridir ve yeri gelince müşteri classı bu iki alt sınıfa özellik ve
                                  // oparasyonlarını kullanacak bu durumda miras yapısını ortaya çıkarır
    {    // kendine has özellikler barındırmalı classlar ortak özellikler base sınıfında olmalı
        //public int Id { get; set; } bu iki özelliği tekrar ayrı ayrı  yerlerde yazmaya gerek yok müşteri clası ortak özellikleri barındırdığı için kendimizi tekrar etmemeliyiz
        //public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
