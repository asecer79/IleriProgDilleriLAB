using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Abstraction.Polymorphism
{
    // ÖDEME SİSTEMİ

    // Ödeme işlemi için arayüz
    public interface IPaymentProcessor
    {
        bool ProcessPayment(decimal amount);
        string GetPaymentMethod();
        void DisplayPaymentDetails();
    }

    // Kredi kartı ödeme işlemi
    public class CreditCardPayment : IPaymentProcessor
    {
        private string _cardNumber;
        private string _cardHolderName;
        private string _expiryDate;

        public CreditCardPayment(string cardNumber, string cardHolderName, string expiryDate)
        {
            _cardNumber = cardNumber;
            _cardHolderName = cardHolderName;
            _expiryDate = expiryDate;
        }

        public bool ProcessPayment(decimal amount)
        {
            // Kredi kartı ödeme işlemi simülasyonu
            Console.WriteLine($"Kredi kartından {amount:C} çekiliyor...");
            Console.WriteLine($"Kart sahibi: {_cardHolderName}");
            Console.WriteLine($"Kart no: {MaskCardNumber(_cardNumber)}");

            // Gerçek uygulamada burada ödeme ağ geçidi ile iletişim kurulurdu
            return true;
        }

        public string GetPaymentMethod()
        {
            return "Kredi Kartı";
        }

        public void DisplayPaymentDetails()
        {
            Console.WriteLine($"Ödeme yöntemi: Kredi Kartı");
            Console.WriteLine($"Kart sahibi: {_cardHolderName}");
            Console.WriteLine($"Kart no: {MaskCardNumber(_cardNumber)}");
            Console.WriteLine($"Son kullanma tarihi: {_expiryDate}");
        }

        private string MaskCardNumber(string cardNumber)
        {
            // Kart numarasını maskeleyerek güvenliği sağlar
            return $"****-****-****-{cardNumber.Substring(cardNumber.Length - 4)}";
        }
    }

    // Banka havalesi ödeme işlemi
    public class BankTransferPayment : IPaymentProcessor
    {
        private string _accountNumber;
        private string _bankName;
        private string _accountName;

        public BankTransferPayment(string accountNumber, string bankName, string accountName)
        {
            _accountNumber = accountNumber;
            _bankName = bankName;
            _accountName = accountName;
        }

        public bool ProcessPayment(decimal amount)
        {
            // Banka havalesi işlemi simülasyonu
            Console.WriteLine($"Banka havalesi ile {amount:C} ödeniyor...");
            Console.WriteLine($"Banka: {_bankName}");
            Console.WriteLine($"Hesap sahibi: {_accountName}");

            // Gerçek uygulamada burada banka API'si ile iletişim kurulurdu
            return true;
        }

        public string GetPaymentMethod()
        {
            return "Banka Havalesi";
        }

        public void DisplayPaymentDetails()
        {
            Console.WriteLine($"Ödeme yöntemi: Banka Havalesi");
            Console.WriteLine($"Banka: {_bankName}");
            Console.WriteLine($"Hesap sahibi: {_accountName}");
            Console.WriteLine($"Hesap no: {_accountNumber}");
        }
    }

    // Dijital cüzdan ödeme işlemi
    public class DigitalWalletPayment : IPaymentProcessor
    {
        private string _email;
        private string _walletProvider;

        public DigitalWalletPayment(string email, string walletProvider)
        {
            _email = email;
            _walletProvider = walletProvider;
        }

        public bool ProcessPayment(decimal amount)
        {
            // Dijital cüzdan ödeme işlemi simülasyonu
            Console.WriteLine($"{_walletProvider} ile {amount:C} ödeniyor...");
            Console.WriteLine($"Dijital cüzdan: {_email}");

            // Gerçek uygulamada burada dijital cüzdan API'si ile iletişim kurulurdu
            return true;
        }

        public string GetPaymentMethod()
        {
            return $"{_walletProvider} Dijital Cüzdanı";
        }

        public void DisplayPaymentDetails()
        {
            Console.WriteLine($"Ödeme yöntemi: {_walletProvider} Dijital Cüzdanı");
            Console.WriteLine($"E-posta: {_email}");
        }
    }

    // Ödeme işlemcisi
    public class PaymentService
    {
        public void ProcessOrderPayment(IPaymentProcessor paymentProcessor, decimal amount)
        {
            Console.WriteLine("Ödeme işlemi başlatılıyor...");
            Console.WriteLine($"Ödeme yöntemi: {paymentProcessor.GetPaymentMethod()}");
            Console.WriteLine($"Ödenecek tutar: {amount:C}");

            bool isSuccess = paymentProcessor.ProcessPayment(amount);

            if (isSuccess)
            {
                Console.WriteLine("Ödeme başarıyla tamamlandı!");
                // Sipariş onaylanır
            }
            else
            {
                Console.WriteLine("Ödeme işlemi başarısız oldu. Lütfen tekrar deneyin.");
                // Hata işleme
            }
        }
    }

    // Kullanım örneği
    public class PaymentExample
    {
        public static void Main()
        {
            PaymentService paymentService = new PaymentService();
            decimal orderAmount = 1299.99m;

            // Farklı ödeme yöntemleri
            IPaymentProcessor creditCard = new CreditCardPayment("1234567890123456", "Ahmet Yılmaz", "12/25");
            IPaymentProcessor bankTransfer = new BankTransferPayment("TR123456789012345678901234", "ABC Bankası", "Mehmet Öztürk");
            IPaymentProcessor digitalWallet = new DigitalWalletPayment("ornek@mail.com", "PayPal");

            // Kullanıcının seçimine göre ödeme işlemi gerçekleştirilir
            Console.WriteLine("Ödeme yöntemi seçin:");
            Console.WriteLine("1. Kredi Kartı");
            Console.WriteLine("2. Banka Havalesi");
            Console.WriteLine("3. Dijital Cüzdan");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    paymentService.ProcessOrderPayment(creditCard, orderAmount);
                    break;
                case "2":
                    paymentService.ProcessOrderPayment(bankTransfer, orderAmount);
                    break;
                case "3":
                    paymentService.ProcessOrderPayment(digitalWallet, orderAmount);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}
