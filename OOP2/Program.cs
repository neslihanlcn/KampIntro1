using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance oluşturma newlemek
            // gerçek kişi
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demir";
            musteri1.TcNo = "12345678910";
            //musteri1.SirketAdi = "? bu özellik gerçek bir kişiye ait değil bu yüzden soyutlamaya ters düşen ilerde zararı olan bir hatadır";

            // kodlama io- tuzel kişi
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "123467543";

            

            // musteri classı (base sınıf) hem gerçek hemde tüzel kişinin referans numarasını tutabilir.
            Musteri musteri3 = new GercekMusteri(); // new = bellekte referans numarası açmak
            Musteri musteri4 = new TuzelMusteri();
            Musteri musteri5 = new Musteri();
            GercekMusteri musteri6 = new GercekMusteri();
            TuzelMusteri musteri7 = new TuzelMusteri();
            // inheritance sayesinde gerektiğinde bu beş şekilde de referans numarası alırız

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1 );
            musteriManager.Add(musteri2);

        }
    }
}
