
#region 01-Operator Overloading
namespace Week10_11._01_ExtensionMethodsAndOperatorOverloading;
/*
public class ComplexNumber
{
    public double Real { get; }
    public double Imaginary { get; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Overloading the + operator
    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Overloading the - operator
    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    // Overloading the * operator   
    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(
            c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
            c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
    }

    // Overloading the / operator
    public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
    {
        double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
        return new ComplexNumber(
            (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator,
            (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator);
    }

    // Overloading the == operator
    public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
    {
        return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
    }
    // Overloading the != operator
    public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
    {
        return !(c1 == c2);
    }

    // Overriding Equals method
    public override bool Equals(object obj)
    {
        if (obj is ComplexNumber other)
        {
            return Real == other.Real && Imaginary == other.Imaginary;
        }
        return false;
    }

    // Overriding GetHashCode method
    public override int GetHashCode()
    {
        return HashCode.Combine(Real, Imaginary);
    }

    //polar form
    public (double magnitude, double angle) ToPolar()
    {
        double magnitude = Math.Sqrt(Real * Real + Imaginary * Imaginary);
        double angle = Math.Atan2(Imaginary, Real);
        return (magnitude, angle);
    }

    //polar tostring
    public string ToPolarString()
    {
        var (magnitude, angle) = ToPolar();
        return $"{magnitude} (cos({angle}) + i sin({angle}))";
    }

    //power method
    public ComplexNumber Power(int exponent)
    {
        double magnitude = Math.Pow(Math.Sqrt(Real * Real + Imaginary * Imaginary), exponent);
        double angle = Math.Atan2(Imaginary, Real) * exponent;
        return new ComplexNumber(
            magnitude * Math.Cos(angle),
            magnitude * Math.Sin(angle));
    }


    public override string ToString()
    {
        if (Real == 0 && Imaginary == 0)
            return "0";

        if (Real == 0)
            return $"{Imaginary}i";

        if (Imaginary == 0)
            return $"{Real}";

        string sign = Imaginary > 0 ? "+" : "-";
        return $"{Real} {sign} {Math.Abs(Imaginary)}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var complex1 = new ComplexNumber(-1, 3);
        var complex2 = new ComplexNumber(2, -1);
        var complex3 = new ComplexNumber(5, 0);
        var complex4 = new ComplexNumber(9, 11);
        var complex5 = new ComplexNumber(9, 11);

        var result =  ((complex1+complex2-complex3)*complex2)/complex4;

        Console.WriteLine(result);

        Console.WriteLine(complex4==complex5);

        Console.WriteLine(complex1.ToPolarString());

        Console.WriteLine(complex1.Power(100));
    }    
}
*/
#endregion



#region 02-Extension Methods
public class ComplexNumber
{
    public double Real { get; }
    public double Imaginary { get; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public override string ToString()
    {
        if (Real == 0 && Imaginary == 0)
            return "0";

        if (Real == 0)
            return $"{Imaginary}i";

        if (Imaginary == 0)
            return $"{Real}";

        string sign = Imaginary > 0 ? "+" : "-";
        return $"{Real} {sign} {Math.Abs(Imaginary)}i";
    }
}

public static class ComplexNumberExtensions
{

    public static ComplexNumber Add(this ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    public static ComplexNumber Subtract(this ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    public static ComplexNumber Multiply(this ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(
            c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
            c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
    }

    public static ComplexNumber Divide(this ComplexNumber c1, ComplexNumber c2)
    {
        double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
        return new ComplexNumber(
            (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator,
            (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator);
    }

    public static bool Equals(this ComplexNumber c1, ComplexNumber c2)
    {
        return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
    }

    public static bool NotEquals(this ComplexNumber c1, ComplexNumber c2)
    {
        return !(c1.Equals(c2));
    }
    
    public static (double magnitude, double angle) ToPolar(this ComplexNumber c)
    {
        double magnitude = Math.Sqrt(c.Real * c.Real + c.Imaginary * c.Imaginary);
        double angle = Math.Atan2(c.Imaginary, c.Real);
        return (magnitude, angle);
    }
    public static string ToPolarString(this ComplexNumber c)
    {
        var (magnitude, angle) = c.ToPolar();
        return $"{magnitude} (cos({angle}) + i sin({angle}))";
    }
    public static ComplexNumber Power(this ComplexNumber c, int exponent)
    {
        double magnitude = Math.Pow(Math.Sqrt(c.Real * c.Real + c.Imaginary * c.Imaginary), exponent);
        double angle = Math.Atan2(c.Imaginary, c.Real) * exponent;
        return new ComplexNumber(
            magnitude * Math.Cos(angle),
            magnitude * Math.Sin(angle));
    }

   
}

class Program
{
    static void Main(string[] args)
    {
        var complex1 = new ComplexNumber(-1, 3);
        var complex2 = new ComplexNumber(2, -1);
        var complex3 = new ComplexNumber(5, 0);
        var complex4 = new ComplexNumber(9, 11);
        var complex5 = new ComplexNumber(9, 11);
        var result = (((complex1.Add(complex2).Subtract(complex3))).Multiply(complex2)).Divide(complex4);
        Console.WriteLine(result);
        Console.WriteLine(complex4.Equals(complex5));
        Console.WriteLine(complex1.ToPolarString());
        Console.WriteLine(complex1.Power(100));

    }
}

#endregion
