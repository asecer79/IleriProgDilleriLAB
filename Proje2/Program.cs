
using Proje1;

namespace Proje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // obje/instance üzerinden erişim.
            A a = new A(); // A sınıfından bir nesne oluşturduk.
           // a.x = 15; // Private erişilemez. ERR
           a.y = 20; // Public erişilebilir.
           //a.z = 25; // Internal erişilemez.//ERR 
           //a.t = 30; // Protected erişilebilir.//ERR
           //a.k = 35; //Protected Internal Erişilemez/ERR


            C c = new C(); // C sınıfından bir nesne oluşturduk.
           // c.x = 15; // Private ERR.
            c.y = 20; // Public erişilebilir.
           // c.z = 25; // Internal ERR.
           // c.t = 30; // Protected ERR.
           // c.k = 35; // Protected Internal ERR.
        }
    }

    
    public class C:A
    {

        public void TestMethod()
        {
            //x = 25; // Private ERR!
            y = 30; // Public OK!
            //z = 35; // Internal ERR!
            t = 40; // Protected OK!
            k = 45; // Protected Internal OK!
        }

    }

}
