using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Abstraction.AbstractClasses
{
    //mesaj gönderme sistemi

    // Soyut sınıf - Örneklenemez
    public abstract class Notification
    {
        public string Recipient { get; set; }

        // Ortak işlemler
        public void SetRecipient(string recipient)
        {
            Recipient = recipient;
        }

        // Alt sınıfların uygulaması gereken metot
        public abstract void Send(string message);
    }

    // Somut sınıf - Örneklenebilir
    public class EmailNotification : Notification
    {
        public string Subject { get; set; }

        public override void Send(string message)
        {
            Console.WriteLine($"E-posta gönderildi: '{Subject}' konusu ile '{message}' mesajı {Recipient} adresine gönderildi.");
        }
    }

    public class SmsNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine($"SMS gönderildi: '{message}' mesajı {Recipient} numarasına gönderildi.");
        }
    }

    // Kullanım örneği
    public class NotificationExample
    {
        //public static void Main()
        //{
        //    // Soyut sınıf doğrudan örneklenemez
        //    // Notification notification = new Notification(); // HATA!

        //    // Somut sınıflar örneklenebilir
        //    EmailNotification email = new EmailNotification();
        //    email.SetRecipient("ornek@mail.com");
        //    email.Subject = "Önemli Bildirim";
        //    email.Send("Hesabınızda önemli bir değişiklik yapıldı.");

        //    SmsNotification sms = new SmsNotification();
        //    sms.SetRecipient("5551234567");
        //    sms.Send("Doğrulama kodunuz: 123456");

        //    // Polimorfizm ile kullanım
        //    Notification notification = new EmailNotification();
        //    notification.SetRecipient("destek@mail.com");
        //    ((EmailNotification)notification).Subject = "Destek Talebi";
        //    notification.Send("Yardım için teşekkürler.");
        //}
    }
}
