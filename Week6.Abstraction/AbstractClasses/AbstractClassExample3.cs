using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Abstraction.AbstractClasses
{
    //LOG SİSTEMİ

    // Arayüz - Sözleşme belirler
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }

    // Somut sınıf - Uygulamayı gerçekleştirir
    public class FileLogger : ILogger
    {
        private string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void LogInfo(string message)
        {
            WriteToFile($"INFO: {message}");
        }

        public void LogError(string message)
        {
            WriteToFile($"ERROR: {message}");
        }

        private void WriteToFile(string content)
        {
            // Dosyaya yazma işlemi
            Console.WriteLine($"'{content}' dosyaya yazıldı: {_filePath}");
        }
    }

    // Başka bir uygulama
    public class DatabaseLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"Veritabanına INFO kaydedildi: {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"Veritabanına ERROR kaydedildi: {message}");
        }
    }
}
