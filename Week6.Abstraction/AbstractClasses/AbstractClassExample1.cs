using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Abstraction.AbstractClasses
{
    /*
       Abstract Classes(Soyut Sınıflar)
       Soyut sınıflar, soyutlama için arayüzler ile somut sınıflar arasında bir köprü görevi görür.
        Abstract Methods (Soyut Metotlar)
       Soyut metotlar, sadece imzaları tanımlanır, gövdeleri yoktur ve alt sınıflarda uygulanmalıdır.
    */

    public abstract class Shape
    {

        public abstract double CalculateArea();

        public void DisplayType()
        {
            Console.WriteLine($"{GetType().Name}- Şekil bilgisi gösteriliyor. ");
        }


    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Soyut metot uygulaması
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }


    /* Concrete Methods(Somut Metotlar)
     Somut metotlar, soyut sınıflarda tam olarak uygulanmış metotlardır.*/

    public abstract class Database
    {
        // Somut metot - uygulaması verilmiş
        public void Connect()
        {
            Console.WriteLine("Veritabanına bağlanıldı.");
        }

        // Soyut metot - alt sınıflarda uygulanmalı
        public abstract void ExecuteQuery(string query);
    }

    public class SqlDatabase : Database
    {
        public override void ExecuteQuery(string query)
        {
            Console.WriteLine($"SQL sorgusu çalıştırılıyor: {query}");
            // SQL özel işlemleri...
        }


    }

    public class MongoDatabase : Database
    {
        public override void ExecuteQuery(string query)
        {
            Console.WriteLine($"MongoDB sorgusu çalıştırılıyor: {query}");
            // MongoDB özel işlemleri...
        }
    }


    /*
      Sealed Override Methods (Mühürlü Geçersiz Kılma Metotları)
sealed anahtar kelimesi ile metotların alt sınıflarda tekrar override edilmesi engellenebilir
     */

    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hav hav!");
        }
    }

    public class SpecialDog : Dog
    {
        // sealed olsaydı bu override mümkün olmazdı
        public override void MakeSound()
        {
            Console.WriteLine("Özel köpek sesi: Woof Woof!");
        }
    }

    // sealed örneği
    public class SealedDog : Animal
    {
        public sealed override void MakeSound()
        {
            Console.WriteLine("Hav hav! (değiştirilemez)");
        }
    }

    // Bu sınıf derleme hatası verecektir çünkü MakeSound sealed
    //public class SuperSpecialDog : SealedDog
    //{
    //    public override void MakeSound() // HATA!
    //    {
    //        Console.WriteLine("Bu mümkün değil!");
    //    }
    //}



}
