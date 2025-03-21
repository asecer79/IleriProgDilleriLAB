namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Car car = new Car("Audi","A3",2025);

            //car.Test();


            ToyPoddle toyPoddle = new ToyPoddle(5);

            Console.WriteLine("\n\n\n");
        }
    }

    //Single Inheritance Example
    public class Vehicle //base class
    {

        public Vehicle()
        {
            Console.WriteLine("Vehicle object was created! Default Constructor");
        }
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;

            Console.WriteLine("Vehicle object was created! Vehicle(string brand, string model, int year)");
        }
       

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping");
        }
    }

    public class Car : Vehicle //derived class
    {
        public Car() : base()
        {
            Console.WriteLine("Car object was created!  Default Constructor");
        }

        public Car(string brand, string model, int year ):base(brand, model, year)
        {
            Console.WriteLine("Car object was created!  Car(string brand, string model, int year ):base(brand, model, year)");
        }
        public int NumberOfDoors { get; set; }

        public override void Start()
        {
            Console.WriteLine("Car is starting");
        }

        public void Drive()
        {
            
            
            Console.WriteLine("Car is driving");
        }

        public void Test()
        {
            Model = "A3";
            Brand= "Audi";
            Year = 2020;
            NumberOfDoors = 4;

            //Start();
            //Drive();
            //Stop();

            this.Start(); 
            base.Start();

        }
    }


    //Multilevel Inheritance Example
    public class Animal
    {
        public Animal(int a)
        {
            Console.WriteLine("public Animal()");
        }
        public void Eat() => Console.WriteLine("Eating...");
    }

    public class Mammal : Animal
    {
        public Mammal(int a):base(a)
        {
            Console.WriteLine("public Mammal()");

        }
        public void Breathe() => Console.WriteLine("Breathing...");
    }

    public class Dog : Mammal
    {
        public Dog(int a): base(a)
        {
            Console.WriteLine("public Dog()");
        }
        public void Bark() => Console.WriteLine("Barking...");

        public void ShowBehaviors()
        {
            Eat();      // From Animal
            Breathe();  // From Mammal
            Bark();     // From Dog
        }
    }

    public class ToyPoddle : Dog
    {
        public ToyPoddle(int a) : base(5)
        {
            Console.WriteLine("public ToyPoddle()");
        }
        public void Play() => Console.WriteLine("Playing...");

    }



    //Hierarchical Inheritance Example
    public class Shape
    {
        public virtual double CalculateArea() => 0;
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea() => Math.PI * Radius * Radius;
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea() => Width * Height;
    }

    public class Square : Rectangle
    {

        public override double CalculateArea() => Width * Height;
    }

    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double CalculateArea() => 0.5 * Base * Height;
    }




}
