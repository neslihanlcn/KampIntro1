using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1  ; i <= 10; i=i+2)
            {
                Console.WriteLine(i);
            }

            string[] notlar = new string[] { "AA", "AB", "BB", "CC","DD","FF" };    // diziyi oluştur döngü ile değerleri döndür.

            for (int i = 0; i < notlar.Length; i++)
            {
                Console.WriteLine(notlar[i]);
            }

            // foreach dizileri daha kolay kullanmak içimn kullanılır çoğunluklla diziler için kullanılır for ise daha genel döngüler içindir.


            foreach (string  not in notlar)
            {
                Console.WriteLine(not);  // for a göre bu kısım farklıdır ve kolaydır
            }
        }
    }
}
