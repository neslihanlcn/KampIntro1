using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService // bu dosyayı database classından oluşturup class adına tıkladığımızda ampulden
                                             // "move type FileLoggerService.cs" dersek bu şekilde farklı dosyaya aktarır alternatif kolaylık sağlar
    {
        public void Log()
        {
            Console.WriteLine("dosyaya  loglandı");
        }
    }
}
