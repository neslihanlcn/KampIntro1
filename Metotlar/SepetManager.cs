using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager 
    {
        public void Ekle(Urun urun)  // bu bir metottur, oparasyon bulundurur
                            // neyi eklemek istediğimi parametrelerle belirtiriz Ekle ( Urun(verinin tipi) urun )  gibi
                            // ürünlere bu parametreyi eklediğimizi belirtiriz
                            // sadece bu alanda parametre eklersek ve bu metodu  başka yerlerde kullandıysak ve parametre
                            // vermediysek o çağırılan  metodun altı kırmızı olur hata verir
                            // bu kısımda parametre verdiysek gerektiği zaman metot çağırırsak o metodada parametre vermek zorundayız.

        {
            Console.WriteLine("Sepete eklendi 1:" + urun.Adi );
        }

        public void Ekle2(string urunAdi,int fiyat,string aciklama )  // parametreyi bu kadar karmaşık vermek yerine urun classını
                                                                      // kullanarak özellikleri orda belirtmek ve parametreyi urun olarak vermek 
                                                                      // bize kulaylık sağlar 
        {
            Console.WriteLine("sepete eklendi 2:"+ urunAdi );
        }
           // c# 23 dersleri youtube engin demiroğ default değerle  örnek
        public void Add3( int sayi1, int sayi2=30) // default olarak sayi2 ye bir değer verilmezse 30 atayarak işlem yapar.
        {
            Console.WriteLine( sayi1+ sayi2 );
        }

        
    }
}
