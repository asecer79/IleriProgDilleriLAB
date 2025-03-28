using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Abstraction.Polymorphism
{
    /*
     *
     * Polimorfizm (Polymorphism) Kavramı
Polimorfizm, nesne yönelimli programlamanın temel ilkelerinden biridir ve "çok biçimlilik" anlamına gelir. Aynı arayüze sahip farklı nesnelerin farklı şekillerde davranabilmesini sağlar.

Polimorfizm
Polimorfizm, bir nesnenin birden fazla formda davranabilme yeteneğidir. C#'ta bu, genellikle kalıtım ve arayüzler aracılığıyla gerçekleştirilir.
     */

    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Hayvan ses çıkarıyor");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hav hav!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Miyav!");
        }
    }

    //internal class Program
    //{

    //    static void Main(string[] args)
    //    {

    //        // Kullanım
    //        Animal myDog = new Dog();
    //        Animal myCat = new Cat();

    //        myDog.MakeSound();  // Çıktı: "Hav hav!"
    //        myCat.MakeSound();  // Çıktı: "Miyav!"


    //        List<Animal> animals = new List<Animal>
    //        {
    //            new Dog(),
    //            new Cat(),
    //            new Dog(),
    //            new Dog(),
    //            new Cat(),
    //            new Dog(),
    //        };

    //        foreach (var animal in animals)
    //        {
    //            animal.MakeSound();
    //        }


    //        SesCikar(new Dog());
    //        SesCikar(new Cat());

    //    }

    //    static void SesCikar(Animal animal)
    //    {
    //        animal.MakeSound();
    //    }
    //}
}
