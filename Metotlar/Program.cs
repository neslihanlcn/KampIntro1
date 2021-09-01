using System;

namespace Metotlar   // tekrar tekrar kullanılacak kodları metot haline getirerek kullanmak çok önemli 
{
    class Program    // CLASSLARIN  BAŞ HARFLERİ HER ZAMAN BÜYÜK YAZILIR.
    {                // classların iki temel kullanımı vardır:
                     // 1. özellik tutmak (property- özellik prop )
                     // 2. operasyon tutar (manager, dal,service, dataaccess- bunlar oparasyonları belirtir SepetManager gibi)
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "kalem";
            urun1.Fiyati = 10;
            urun1.Aciklama = "uçlu kalem";
            urun1.StokAdedi = 100;  // sadece burda eklersek diğer ürünlerde eklemezsek hata vermez ekle2() metodudundaki
                                    // gibi yapı kullanırsak-önceden özellikleri parametre içine yazarsak-  hata verir
            

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "telefon";
            urun2.Fiyati = 5000;
            urun2.Aciklama = "son teknoloji";
           

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "tablet";
            urun3.Fiyati = 1000;
            urun3.Aciklama = "hafif, kulay kullanım";
            

            Urun urun4 = new Urun();
            urun4.Id = 4;
            urun4.Adi = "bilgisayar";
            urun4.Fiyati = 10000;
            urun4.Aciklama = "çok kullanımlı";
            

            Urun urun5 = new Urun();
            urun5.Id = 5;
            urun5.Adi = "kulaklık";
            urun5.Fiyati = 200;
            urun5.Aciklama = "kablosuz kulaklık";
            



            Urun[] urunler = new Urun[] { urun1,urun2,urun3,urun4,urun5  };
            foreach (Urun urun in urunler )   // ürünleri döndürmek için gerekli 
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine("ADI:" + " " + urun.Adi );
                Console.WriteLine("FİYATI:" + " " + urun.Fiyati+ "TL");
                Console.WriteLine("AÇIKLAMA:" + " " + urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("--------metotlar-----");

            // class çağırma- o classın önce instancesi oluştururuz yani class örneğini sonrada metotdu çağırırız
                    
            // ENCAPSULATİON -AYRI AYRI BÜTÜNÜN PARÇASI OLAN NESNELERİ KODlARI DÜZENE SOKMAK- ekle2() örneği
            // sayfalarca aynı metodu çağırıp o kodu kullanırız ama tek bir
            // değişiklikte -yani o classa ait özellik ekleyip çıkarılmak istenince- sayfaları
            // tek tek dolaşıp değiştirmek yerine metodun olduğu classı bulup özellik ekleyerek- çıkararak
            // sorunu çözeriz bu encapsulation denir. örnek başta stok adedi özelliği yokken ve bu kadar
            // sayfaya o metodu kullandıysak urun classına giderek o özelliği ekleriz.
            // PARAMETRE vererek bunları düzene sokarız parametre olmazsa yazdırmak istediğimiz şeyler
            // karmakarışık olacaktır ekle2() örneği

            SepetManager sepetManager = new SepetManager(); // class örneği 1. adım
            sepetManager.Ekle(urun1 ); // metot çağırma 2. adım
            sepetManager.Ekle(urun2); // tekrar tekrar aynı kodu kullanma kolaylığı sağladı.
                                      // bu  kodda herhangi bir eğişiklik gelirse SepetManager classına gidilir tek
                                      // seferde değişiklik yapılır 
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun4);
            sepetManager.Ekle(urun5);

            sepetManager.Add3(30);
            
                                                            // **************
            sepetManager.Ekle2("kalem", 50, "uçlu kalem"); // ürünü bu şekilde belirtirsek stok adedini özellik olarak eklersek metoda
                                                           // gidip ekleme yaparız  ve mevcut olan tüm ürünler hata verir tek tek onlardada
                                                           // stok adedini eklememiz gerekir bunun yerine urun classı oluşturup özellikleri ve ürün  değişkenlerini
                                                           // farklı yerlerde yukardaki gibi belirtirsek hata vermez
          //*** METODUN İÇİNE ÜRÜN DEĞİŞKENLERİ YERİNE PARAMETRE YAZMAK EN DOĞRU ADIMDIR
          //KODU TEK BİR NOKTADAN YÖNETMEK KARMAŞIKLIĞI AZALTIR
            
            
            // encapsulation örneği- kodun parametresini veri tipi ile özelliklerini
            // parametre olarak yazarsak sayfalarca olan metodu her seferinde bu
            // şekilde çağırırız ilerledikçe bu karmaşaya yol açar
             // parametreyi  urun olarak verirsek kolaylaşmış olur

            // PARAMS metodu ile istediğimiz kadar parametre kullanabiliriz overloading olmadan
        }
    } 
}
