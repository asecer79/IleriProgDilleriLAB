using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Abstraction.AbstractClasses
{
    //Çoklu Arayüz Kalıtımı
    //Akıllı cihaz örneği
    public interface IConnectable
    {
        bool Connect();
        void Disconnect();
    }

    public interface IChargeable
    {
        int BatteryLevel { get; }
        void Charge();
    }

    public interface IPlayable
    {
        void Play();
        void Pause();
    }

    // Çoklu arayüz uygulaması
    public class SmartPhone : IConnectable, IChargeable, IPlayable
    {
        public int BatteryLevel { get; private set; }

        public SmartPhone()
        {
            BatteryLevel = 50;
        }

        public bool Connect()
        {
            Console.WriteLine("Telefon bağlandı.");
            return true;
        }

        public void Disconnect()
        {
            Console.WriteLine("Telefon bağlantısı kesildi.");
        }

        public void Charge()
        {
            BatteryLevel = 100;
            Console.WriteLine("Telefon şarj edildi.");
        }

        public void Play()
        {
            if (BatteryLevel > 10)
            {
                Console.WriteLine("Müzik çalıyor...");
                BatteryLevel -= 5;
            }
            else
            {
                Console.WriteLine("Düşük pil seviyesi! Lütfen şarj edin.");
            }
        }

        public void Pause()
        {
            Console.WriteLine("Müzik duraklatıldı.");
        }
    }

    //Kullanım
    public class DeviceManager
    {
        public void ManageDevice(IConnectable device)
        {
            device.Connect();

            // Cihaz şarj edilebilir mi?
            if (device is IChargeable chargeableDevice)
            {
                Console.WriteLine($"Pil seviyesi: {chargeableDevice.BatteryLevel}%");
                if (chargeableDevice.BatteryLevel < 30)
                {
                    chargeableDevice.Charge();
                }
            }

            // Cihaz müzik çalabilir mi?
            if (device is IPlayable playableDevice)
            {
                playableDevice.Play();
                // Biraz sonra
                playableDevice.Pause();
            }

            device.Disconnect();
        }
    }

}
