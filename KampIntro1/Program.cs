using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.70;
            double dolarBugun = 7.60;


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış oku");

            }
            else
            {
                Console.WriteLine ("eşittir oku");
            }
        }
    }
}
