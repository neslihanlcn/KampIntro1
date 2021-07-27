using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Ders ders1= new Ders();
            ders1.dersAdi = "matematik";    // DEĞİŞKEN  kurs adlı classın değişkenleri  
            ders1.egitmen = "ayşe";
            ders1.ogrenciSayisi = 20;

            Ders ders2 = new Ders();
            ders2.dersAdi = "türkçe";     // DEĞİŞKEN 
            ders2.egitmen = "fatma";
            ders2.ogrenciSayisi = 30;

            Ders ders3 = new Ders();
            ders3.dersAdi = "sosyal bilgiler";    // DEĞİŞKEN 
            ders3.egitmen = "ahmet";
            ders3.ogrenciSayisi = 25;


            //*****
            Ders[] dersler = new Ders[] { ders1, ders2,ders3 };  // dersler arrayi

            foreach (Ders  ders in dersler )
            {
                Console.WriteLine(ders.dersAdi   );   // ders i takma ad olarak tanımladık ve dersler arrayindeki tüm
                                                      // dersleri dinamik bi şekilde dönmesi için  ders takma adı sayesinde
                                                      // tüm derslerin adını alt alta yazdırdık
            }

            
        }
    }

    class Ders
    {
        public string dersAdi { get; set; }
        public string egitmen { get; set; }
        public int ogrenciSayisi { get; set; }

    }
}
