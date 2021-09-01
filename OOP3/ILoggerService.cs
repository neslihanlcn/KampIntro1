using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ILoggerService // interfacenin içinde sadece metodlar olur içi dolu olamaz bağlandığı alt sınıflar kendi asıl yapılacak işlemleriyle doldururlar
                             // bu sadece imza kısmıdır şablon ekle ilgili classlara implemente et**
    {
        void Log();
    }
}
