using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
      interface IKrediManager // krediManager diğer alt sınıflar için mirascı konumunda
                       // burada olduğu gibi diğer alt sınıflarında hesapla operasyonunu kullanması gereken durumlar oluşabilir.
                       // bu yüzden tekrar tekrar aynı kodu yazmaktansa base sınıf sayesinde temiz bir kod yazarız
                       // ama bu üç tane kredi çeşidi imzası aynı olan ama içeriği farklı olan işlemler yapabilir bu yüzden INTERFACE KULLANIRIZ
    {                  // kodun okunurluğunu arttırmak için interface iminin başın I harfi gelir
        // daha sonra bu base sınıfa bağlı olan sınıflardanda interface sınınıfına I ekleriz ve yanda yanan ampulden implement interface yi seçer hatayı düzeltiriz
        // şablon oluştur ve ilgili classlara implemente etmek kısaca (şablon ıKredimanager void hesapla kısmı)
        //public void Hesapla()
        //{
        // interfacesiz hali

        // birbirinin alternatifi olan ama kod içerikleri farklı durumlar için kullanırız interface (IKrediManager)
        // loglama - sistemde oluşan herketliliği gösteren olaydır kim ne zaman hangi operasyonu çağırdı gibi. loglar dosyalarda tutulabilir veya veritabanında tutulabilir, sms mail gönderilmesi hepsi loglar ama içerikleri farklıdır
        // birden fazla metod içerebilir

            void Hesapla();
            void BiseyYap(); 
        
    }
}
