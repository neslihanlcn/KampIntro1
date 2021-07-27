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
            Console.WriteLine("Sepete eklendi:" + urun.Adi );
        }

        public void Ekle2(string urunAdi,int fiyat,string aciklama )  // parametreyi bu kadar karmaşık vermek yerine urun classını
                                                                      // kullanarak özellikleri orda belirtmek ve parametreyi urun olarak vermek 
                                                                      // bize kulaylık sağlar 
        {
            Console.WriteLine("sepete eklendi"+ urunAdi );
        }
    }
}
