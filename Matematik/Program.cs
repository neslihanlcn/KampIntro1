using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);  // DortIslem programında classa int sayi1 gibi
                                    // parametre vererek bu metodu farklı değişkenlerle
                                    //  defalarca metodu çağırarak kullanabiliriz farklı farklı sayılarla toplama
                                    //  operasyonu gerçekleşir  urunler için olan operasyondada
                                    //  türü urun olan  değişkenlere paramatre vererek metodu oluşturuz
            dortIslem.Topla(10, 8);
        }
    }
}
