using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri : Musteri  // musterinin özelliklerini ve operasyonlarını bu alt sınıfta kullanmak istiyorsak miras inheritance kullanırız.
                                   // bu iki alt sınıfın ortak özellikleri muşteri clasında olmalıdır ıd ve müşteri no gibi
    {
        // public int Id { get; set; }   bu iki özelliği tekrar ayrı ayrı  yerlerde yazmaya gerek yok müşteri clası ortak özellikleri barındırdığı için kendimizi tekrar etmemeliyiz
        //public string MusteriNo { get; set; }
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
