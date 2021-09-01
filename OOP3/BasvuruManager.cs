using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices  ) // bu parametreyi eklemeden aşağıya üç kredi sınıfından birini yazarsak bütün başvurular o sınıf için oluşur
                                 // bu hataya düşmemek için parametre olarak bütün sınıfların mirasçısı olan base sınıfı veririz ortak base sınıf olduğu için
                                 //program.cs de hangi krediyi seçeceğimiz seçenek olarak gelir ve çağırdığımız basvuruyap metodunun içine parametre olarak o seçtiğimiz kredi geçer ve ona göre işlem yapılır
                                 // hem veritabanına loglmak hemde sms atmak istiyorsam basvuruyap  metodunun içine base logger sınıfının listini açarım-önemli
                                 // listedeki loglarıda döndürmesi için foreach açarım
        {      
            krediManager.Hesapla(); // burada sadece tek bir kredinin hesabını yapar ama aşağıdaki foreach li  sayısı belirsiz liste yapısındaki bütün kredileri hesaplar
            //loggerService.Log();  liste log yaptığım için burayı iptal ederim foreach açarım
            foreach (var loggerService in loggerServices )
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler) // ıkredi türünde bir liste ver
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();  // krediler adında listeyi kredionbilgilendirmesiyap metoduna parametre olrarak verdik ve liste içindeki her krediyi tek tek hesaplaması için foreachle döngü içine aldık
            } 
        }
    }
}
