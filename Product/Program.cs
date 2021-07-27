using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "telefon";
            urun1.urunSayisi = 50;
            urun1.kategory = "teknoloji";
            urun1.aciklama = "hafif,kullanışlı";

            Urun urun2 = new Urun();
            urun2.urunAdi = "dizüstü bilgisayar";
            urun2.urunSayisi = 60;
            urun2.kategory = "teknoloji";
            urun2.aciklama = "hafif,çoklu kullanım";

            Urun urun3 = new Urun();
            urun3.urunAdi = "oyuncak araba";
            urun3.urunSayisi = 100;
            urun3.kategory = "oyuncak";
            urun3.aciklama = "güvenilir, kimyasal madde içermez";

            Urun urun4 = new Urun();
            urun4.urunAdi = "fincan seti";
            urun4.urunSayisi =600;
            urun4.kategory = "mutfak";
            urun4.aciklama = "desenleri solmaz";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3,urun4 };

            foreach (Urun urun in urunler) 
            {
                Console.WriteLine(urun.urunAdi + " "+ urun.urunSayisi + " "+ urun.kategory );
            }

        }
    }


    class Urun
    {
        public string urunAdi { get; set; }
        public string aciklama { get; set; }
        public int urunSayisi { get; set; }
        public string kategory { get; set; }
    }
}
