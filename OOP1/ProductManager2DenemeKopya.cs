using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager2DenemeKopya
    {
        public void Add(Product product) // parantez içindeki parametre bize neyi nasıl göstereceğimizi verir
                                         // "Product türünde product ver" der BUNA  ENCAPSULATİON DENİR
                                         // parametre alanına bir sürü bir şey yazmak yerine  sadece ürün product clasını
                                         // yazmaya denir bir sürü virgülle oyalanmak yerine classta topladığımız tüm
                                         // özellikleri sade bir şekilde yazmak kolaylık sağlar
        {
            product.ProductName = "kamera";   //product1in adı lamba ama burda metodun içğinde kamera yazdık ekrana kamera çıktısını verir
                                              //çünkü referans numarası üzerinden değer atar program cs de 101 lambaydı ama burda 101 e
                                              //kamerayı atadık numaraya ne atanırsa o çıktıyı verir.

        }

        public void Delete(Product product)
        {

            Console.WriteLine("bu ürün silindi:" + "" + product.ProductName);
        }


        // deneme 
        public void BiseyYap(int sayi)
        {
            sayi = 99;  // burada ise 99 tanımladık ama ama main de yazdığımız sayi 100 e tanımlı 100 çıktısını verir değer tip olduğu için
                        // değer tiplerde atamalar tamamen değer üzerine olur yani değer ne ise (100 ) gönderiir ve o değerle
                        // işi tamamen biter
                        // int sayi = 100;
                        // productManager.BiseyYap(100); basitce böyle demektir değeri verir ve işi biter
        }



        // PROGRAM.CS* KOPYASI   
        //class Program
        //{
            //static void Main(string[] args)
            //{
                //Product product1 = new Product(); // 2. yöntemde parantez açılmıyor sadece süslü parantezin içine veriler eklenir
                //product1.Id = 1;
                //product1.CategoryId = 2;
                //product1.ProductName = "lamba";
                //product1.UnitPrice = 100;
                //product1.UnitsInStock = 50;

                // değişken ekleme iki ve daha fazla şekilde gösterilebilir
                // birinci yol yukardaki ,ikinci yol aşağıdaki gibi eklenebilir

               // Product product2 = new Product
                //{
                   // Id = 2,
                    //CategoryId = 3,
                    //ProductName = "masa",
                    //UnitPrice = 300,
                    //UnitsInStock = 30
               // };

                // add operasyonunu kullanmak için örneğini çağırmak gerekir
                // normal değer atamaktan farkı yok new diyerek heap bölgeden referans nosu alırız
                //stack                          heap
                //ProductManager productManager = new ProductManager();
                //productManager.Add(product1); // ekledim ama ne ekleyeyim burada parametreler devreye girer eklemek
                                              // istediğimiz şeyi parametre olarak yazarız
                //Console.WriteLine(product1.ProductName); // referans numaraları üzerinden gider product1 101 ise ne atanırsa onu verir

                //int sayi = 100;
                //productManager.BiseyYap(sayi);
                //Console.WriteLine(sayi); // 99 ile bir bağlantısı tutmaz



                //productManager.Delete(product1); // yeni bir metot çağırma örneği oluşturulmaz eğer farklı classlarda
                                                 // ise yeniden newlenir  farklı classlarda 


            }
        }
