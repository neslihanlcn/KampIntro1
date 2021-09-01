using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10; // 10 u sayi1 e atar 
            int sayi2 = 20; // 20 yi sayi2 ye atar
            sayi1 = sayi2; // sayi2 nin değerini sayi1 e atar yani sayi1 in yeni değeri 20
            sayi2 = 30;   
            // sayi1 ?? = 20  başka bir yerde de aynı  ada sahip (sayi1 )  değer olabilir
            // mesela farklı bir yerde  sayi1= 50  gösterirse bu iki sayi1 in birbiriyle alakası yoktur
            // o an hangi değer atanırsa onun cevabı odur. sadece iki aynı ada sahip, birbirinden farklı değişkenlerdir.
            // ama iki değişken birbirini etkilemesini istiyorsak her iki tarafın başına ref kodunu yazarız
            // ref key değer tiplerin referans tipler gibi kullanılabilmesini sağlar 
            // out key ise ref ile aynı işlevi görür tek fark outta değişkene değer atamazsak da sorun olmaz
            // ref de değişkenlere kesinlikle değer atanır.


            int[] sayilar1 = new int[] { 10, 20, 30 };   
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] ??? = 999
            // diziler değer yerine referans numarası atar yani sayilar1 in referans numarası
            // 101 (temsili), sayilar2 nin referans numarası 102 desek 
            // arka planda gerçekleşen 

            // stack                      heap
            //sayilar1               101-[10,20,30]  sayilar1
            //sayilar2               102-[100,200,300 ]  sayilar2 
            // sayilar2 i sayilar1 ye atarsak referans numaralarını atamış oluruz

            // yeni hali 
            // stack            heap
            // sayilar1           102- .net arka planda bu kısım da atama olmayacağı için siler   [10,20,30]  sayilar1
            // sayilar2           102-   [999,200,300 ]  sayilar2 
            // sayilar1 in yeni değerleri 999 200 300 şeklinde olur 

            // int decimal float bool double = değer tip - değer atar
            // arry class interface = referans tip- referans numarası atar

        }
    }
}
