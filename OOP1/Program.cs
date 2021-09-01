using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); // 2. yöntemde parantez açılmıyor sadece süslü parantezin içine veriler eklenir
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "lamba";
            product1.UnitPrice = 100;
            product1.UnitsInStock = 50;

            // değişken ekleme iki ve daha fazla şekilde gösterilebilir
            // birinci yol yukardaki ,ikinci yol aşağıdaki gibi eklenebilir

            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName ="masa",
            UnitPrice = 300, UnitsInStock = 30};

            // add operasyonunu kullanmak için örneğini çağırmak gerekir
            // normal değer atamaktan farkı yok new diyerek heap bölgeden referans nosu alırız
            //stack                          heap
            ProductManager productManager = new ProductManager() ;
            productManager.Add( product1 ); // ekledim ama ne ekleyeyim burada parametreler devreye girer eklemek
                                            // istediğimiz şeyi parametre olarak yazarız
            Console.WriteLine(product1 .ProductName ); // referans numaraları üzerinden gider product1 101 ise ne atanırsa onu verir

            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi); // 99 ile bir bağlantısı tutmaz

            productManager.Add(product2);


            
            productManager.Delete(product1); // yeni bir metot çağırma örneği oluşturulmaz eğer farklı classlarda
                                             // ise yeniden newlenir  farklı classlarda 
                                             
            
            // void- return farkı**
            productManager.Topla2(3, 6);
            // return ile çıktının üzerinde tekrar çalışmak istersek bu şekilde atayarak tekrar kullanabiliriz
            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu *5);  //veya
            Console.WriteLine(productManager.Topla(3, 6)*5);
        
        }

    }
}
