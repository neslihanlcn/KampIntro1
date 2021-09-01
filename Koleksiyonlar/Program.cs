using System;
using System.Collections.Generic; // listler için hazır halde gelmez biz ampulden ekleriz içindeki ki koleksiyonları ekledikten sornra kullanabiliriz

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "ali", "ayşe", "fatma", "gül" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            // arrayler sabit elemanlıdır dört elemanlı yaptıysak onu beş elemana çıkaramayız yaparsakta önceki elemanları kaybederiz
            // yeni bir elemanda ekleyemeyiz çünkü sabit elemanlıdır
            // yukardaki diziye 4 . veya 5 eleman eklemek istersek aşağıdaki gibi kesinlikle yapmamalıyız.
            // çünkü  new diyerek tekrar dizi açarsak yukarıdakilerden bağımsız yeni bir dizi oluştururuz.
            // ve bu ikisini birleştirmek için bir yol değildir iki bağımsız dizi oluşturmaktır. 
            isimler = new string[5];
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]); //  dört elemanlı bir dizi oluşturduk 4. elemanını ilker diye adlandırdık ama
                                           //  diğer üç eleman boş olarak kalır yerleri bellidir ama herhangi bir değişken yoktur
            Console.WriteLine(isimler[0]); // boş kalır

            // c# da genelllikle array kullanılmaz bu gibi sorunlar yaratmamak için
            // koleksiyonlar kullanılır çoğu zaman liste yöntemini kullanacağız
            // List yazdıktan sonra yanındaki ampulden default olarak gelmeyen sınıfı seçeriz yani "using system.colletions.generic"
            // ekleriz ve yukardaki dizileri tekrar sabit eleman sınırı olmadan yazarız

            List<string> isimler2 = new List<string> {"ayşe","fatma","ali","gül" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker"); // listlerde yeni eleman eklemek için koleksiyonlardan add çağrılır.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
