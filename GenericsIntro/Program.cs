using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            // string türünde bir liste 
            isimler.Add("engin");


            // sayilar listesindeki elemanları döndür ve add metoduyla eleman ekle-örnek
            List<int> sayilar = new List<int> {1,2,3,4,5,6,7 };
            sayilar.Add(40);
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            // int türünde dizi-array
            int[] sayilar2 = new int[] {1,2,3,4,5,6,7 };
            Console.WriteLine(sayilar2.Length);

           




        }
    }
}
