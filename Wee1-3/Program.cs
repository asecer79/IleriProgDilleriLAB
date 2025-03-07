using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Wee1_3
{
    class Program
    {
        //entry point// giriş noktası fon.
        static void Main(string[] args)
        {
            //Primitive & value types
            int a = 5;
            float b = 2.3f;
            double d = 36.9;
            decimal c = 369.89M;
            char c1 = 'A';
            bool b1 = true;

            //value types//complex
            Student student = new Student();
            var res = Colors.Red;

            //Reference Types:
            int[] list1 = new[] {1,2,3 };
            MyClass myClass = new MyClass();
            List<int> list2 = new List<int>();

            //pointer types
            //unsafe
            //{
            //    int * p = (int*)p;

            //}

            counter = 5;
            //PI = 23;

            Console.WriteLine("Hello world");
        }

        //Static types
        static int counter = 0;

        //const
        const double PI = 3.15;

        //

        static MyClass myClass = new MyClass();

    }

    class MyClass
    {
         int id;
         int no;

         string name;

         int sum(int a, int b)
         {
             return a + b;
         }


    }
    enum Colors
    {
        Red =15,
        Green =46,
        Blue =69,
    }
    struct Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
