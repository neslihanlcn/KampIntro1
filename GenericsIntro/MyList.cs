using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro // bir classı list yapmak list<string> yerine kendi listimizi oluşturmak
{
   class MyList <T>  // T - kullanıcı hangi veri tipini verirse o verdiği tipi kullanır.
                     // içinde string int...class parametre hepsi vardır kullanıcının verdiğine göre hareket eder, kısıtlamaz
    {
        T[] items;  // yaptığımız metodları saklamak için- classı newlediğimde t[]items arrayini oluşturmam gerek
                    // bunun içinde yani 0 elemanlı array oluşturmam gerek 0 elemanlı bile olsa bu dizinin oluşması gerek yoksa referans hatası verir
                   // bunun için ctor yazar tab tab dersek aşağıdaki gibi classın adıyla aynı yapı oluşur
          
        // classı  herhangi bir yerde newlersek aşağıdaki otomatik çalışacak artık
        // ctor-constructor
        public MyList()
        {                        // 0 elemanlı dizi yapısı-newlendiğinde otomatik çalışan kısım
            items = new T[0];   //classı herhangi bir yerde newlediğimiz anda bu 0 elemanlı array otomatik çalışır
        }
        public void Add(T item) // item-eleman - T tipinde eleman mylist için bizim oluşturduğumuz bir metot ama list in kendi
                                // içinde hazır metodlarıda var mylist kendi oluşturduğumuz liste hazırıda kullanabilirdik.
                                // Mylist generics yapılara bir örnek sadece
                                // yukarıdaki 0 elemanlı diziyi oluşturduğumuza göre artık diziye eleman ekleyebiliriz
        {
            T[] tempArray = items;  // geçici olarak emanet eder ondan sonra eleman sayısını bir artırırz
            items = new T[items.Length+1]; // 0 elemanlı oluşturduk diziyi bu  yüzden burda ekleme yapmak için bir bir artırılması gerek eleman sayısının
                                           // bu yüzden böyle bir kod yazdık items. length dizinin eleman sayısı demek
                                           // mevcuttaki eleman sayısnını bir artır dinamik bir yapı
                                           // her newlendiğinde bir önceki referans sayısı silinir bu yüzden referans numarasını bir şeye newlemek gerek
                                           // bunada tempArray yani geçici diziye referans numarasını tuttururuz
            for (int i = 0; i < tempArray.Length; i++) // şimdi geçici olarak verdiğimiz elemanları geri almak için bu adımı yaparız
            {
                items[i] = tempArray[i]; // geçici değerleri sırasıyla kendi üzerime alırım (itemsin üzerine geri alırım)
            }
            items[items.Length - 1] = item; // asıl istenen yeri bu adımda açtık ?? ARAŞTIR??
        }
        

        // listler arka planda bir arrayi yönetir o yüzden bizde mylist için bir array olışturmalıyız
    }
}
