using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager // I ekleyip ampulden implement interface ettik ve base sınıftaki metotdların tamamını burada da  otomotik olarak oluştu
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()      // hesapla işlemi aynı ama içerikte farklı bir işlem yaparsak bu şekilde base sınıfı implemente ederek metodu oluşturabiliriz
                                   // hesapla metodu diğer sınıflardada olduğu gibi sabittir ama içerikte -console writelindeki kısımı gibi- farklı işlem gerektirirse interfaceyi implemente edebiliriz.
        {
            Console.WriteLine("konut kredisi ödeme planı hesaplandı");
        }
    }
}
