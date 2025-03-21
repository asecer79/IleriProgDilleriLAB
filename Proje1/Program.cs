using System.Runtime.CompilerServices;

namespace Proje1//assembly
{
    class Program
    {
        static void Main(string[] args)
        {

            A a = new A(); // A sınıfından bir nesne oluşturduk.

            // obje/instance üzerinden erişim.

            // a.x = 15; // Private erişilemez. ERR
            a.y = 20; // Public erişilebilir.
            a.z = 25; // Internal erişilebilir.//Proje içinden her yerden erişilebilir.
            //a.t= 30; // Protected erişilemez. ERR//
            a.k = 35; // Protected Internal erişilebilir.//Proje içinden her yerden erişilebilir.


            B b = new B(); // B sınıfından bir nesne oluşturduk.
            // obje/instance üzerinden erişim.
            //b.x = 15; // Private erişilemez. ERR
            b.y = 20; // Public erişilebilir.
            b.z = 25; // Internal erişilebilir.//Proje içinden her yerden erişilebilir.
            // b.t = 30; // Protected erişilemz.//ERR.
            b.k = 35; // Protected Internal erişilebilir.//Proje içinden her yerden erişilebilir.

            Console.WriteLine("Hello, World!");


        }
    }

    public class A
    {


        private int x = 10;

        public int y = 5;

        internal int z = 15;

        protected int t = 20;

        protected internal int k = 20;




        private void M1()
        {
            Console.WriteLine("Foo");
        }

        private void M2()
        {
            Console.WriteLine("Foo");
        }

        public void TestMethod()
        {
            x = 25; // Private OK!
            y = 30; // Public OK!
            z = 35; // Internal OK!
            t = 40; // Protected OK!
            k = 45; // Protected Internal OK!
        }
    }


    internal class B : A  //B a dan türer / B inherits A,  B:derived class, A: Base class
    {


        public void TestMethod()
        {
            // x = 25; // Private ERR!
            y = 30; // Public OK!
            z = 35; // Internal OK!
            t = 40; // Protected OK!
            k = 45; // Protected Internal OK!
        }
    }



}
