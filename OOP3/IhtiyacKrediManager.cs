using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager // I ekleyip ampulden implement ettik ve base sınıftaki metotdların tamamını burada da yazdırdık
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()              // hesapla işlemi aynı ama içerikte farklı bir işlem yaparsak bu şekilde base sınıfı implemente ederek metodu oluşturabiliriz
                                         // hesapla metodu diğer sınıflardada olduğu gibi sabittir ama içerikte -console writelindeki kısım gibi- farklı işlem gerektirirse interfaceyi implemente edebiliriz.
        {
            Console.WriteLine("ihtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
