using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Abstraction.AbstractClasses
{
    // Gerçek hayat örneği - Ödeme sistemi
    public interface IPaymentMethod
    {
        bool ProcessPayment(decimal amount);
        string GetPaymentType();
    }

    public abstract class PaymentProcessor
    {
        protected string _merchantId;

        public PaymentProcessor(string merchantId)
        {
            _merchantId = merchantId;
        }

        // Somut metot - tüm ödeme işlemcileri için ortak
        public void ValidateMerchant()
        {
            Console.WriteLine($"Satıcı doğrulandı: {_merchantId}");
        }

        // Soyut metot - her ödeme tipi kendi doğrulamasını yapmalı
        public abstract bool ValidatePayment();
    }

    // Hem abstract class'tan inherit hem interface'i implement eden sınıf
    public class CreditCardPayment : PaymentProcessor, IPaymentMethod
    {
        private string _cardNumber;
        private string _expiryDate;

        public CreditCardPayment(string merchantId, string cardNumber, string expiryDate)
            : base(merchantId)
        {
            _cardNumber = cardNumber;
            _expiryDate = expiryDate;
        }

        public override bool ValidatePayment()
        {
            // Kredi kartı validasyon işlemleri
            return _cardNumber.Length == 16 && !string.IsNullOrEmpty(_expiryDate);
        }

        public bool ProcessPayment(decimal amount)
        {
            ValidateMerchant();
            if (ValidatePayment())
            {
                Console.WriteLine($"Kredi kartı ile {amount:C} ödeme işlendi.");
                return true;
            }
            return false;
        }

        public string GetPaymentType()
        {
            return "Kredi Kartı";
        }
    }
}
