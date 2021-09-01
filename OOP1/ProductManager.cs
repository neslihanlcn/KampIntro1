using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // operasyon bulundurur.
    {
        public void Add( Product product ) // parantez içindeki parametre bize neyi nasıl göstereceğimizi verir
                                           // "Product türünde product ver" der BUNA  ENCAPSULATİON DENİR
                                           // parametre alanına bir sürü bir şey yazmak yerine  sadece ürün product clasını
                                           // yazmaya denir bir sürü virgülle oyalanmak yerine classta topladığımız tüm
                                           // özellikleri sade bir şekilde yazmak kolaylık sağlar
        {
            product.ProductName = "kamera";   //product1in adı lamba ama burda metodun içinde kamera yazdık ekrana kamera çıktısını verir
                                              //çünkü referans numarası üzerinden değer atar program cs de 101 lambaydı ama burda 101 e
                                              //kamerayı atadık numaraya ne atanırsa o çıktıyı verir.

        }

        public void Delete(Product product )
        {
            
            Console.WriteLine("bu ürün silindi:"+ ""+ product.ProductName );
        }


        public void Update (Product product)
        {
            Console.WriteLine("bu ürün güncellendi:"+""+ product .ProductName );
        }


        // deneme 
        public void BiseyYap (int sayi)
        {
            sayi = 99;  /* burada ise 99 tanımladık ama ama main de yazdığımız sayi 100 e tanımlı 100 çıktısını verir değer tip olduğu için
                         değer tiplerde atamalar tamamen değer üzerine olur yani değer ne ise (100 ) gönderiir ve o değerle
                         işi tamamen biter
                         int sayi = 100;
                        productManager.BiseyYap(100); basitce böyle demektir değeri verir ve işi biter */
        }


       /* VOİD - RETURN FARKI
         void de  emir verilen oparasyonu yapar ve çıktısını verir o çıktıyı tekrar herhangi bir yerde kullanamaz
       ama return de elde edilen çıktı istenilen her yerde kullanılabilir. banka sistemlerinde çok kullanılır
       void sadece git yap bitir mesela 2+3 ü topla çıktıyı ver bitir ama 2+3 ün sonucunu ben 5 ile çarpmak istersem void ile olan formülü tekrar kullanamam

        */

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        
        public void Topla2 (int sayi1,int sayi2)
        {
            Console.WriteLine(sayi1+ sayi2);
        }

    }
}
