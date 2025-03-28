using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Abstraction.Polymorphism
{
    /*
     *
     * Virtual Methods Revisited (Sanal Metotlar)
Sanal metotlar (virtual), alt sınıflar tarafından geçersiz kılınabilen (override edilebilen) metotlardır. Bu, polimorfizmin temelini oluşturur.
     */
    public class Shape
    {
        public virtual double CalculateArea()
        {
            Console.WriteLine("Shape Area");
            return 0;
        }

        // Sanal olmayan (override edilemez) metot
        public void DisplayType()
        {
            //Console.WriteLine($"Bu bir {GetType().Name} nesnesidir.");
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            Console.WriteLine("Circle Area");
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            Console.WriteLine("Rectangle Area");
            return Width * Height;
        }
    }

    //internal class Program
    //{

    //    static void Main(string[] args)
    //    {

    //        List<Shape> shapes = new List<Shape>
    //        {
    //            new Circle(5),
    //            new Rectangle(3, 4),
    //            new Circle(7),
    //            new Rectangle(2, 6)
    //        };

    //        foreach (var shape in shapes)
    //        {
    //            Console.WriteLine($"Alan: {shape.CalculateArea()}");
    //            shape.DisplayType();
    //        }


    //    }

      
    //}
}
