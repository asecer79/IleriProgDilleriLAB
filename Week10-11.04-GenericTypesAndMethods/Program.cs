

#region Generic Class
/*
 Generic sınıflar, her veri tipiyle çalışabilen sınıflar tanımlamamıza olanak sağlar. Aynı işlemleri (ekleme, silme, listeleme gibi) hem Customer, hem Product, hem Order gibi sınıflar için ayrı ayrı yazmak yerine, bir generic Repository<T> sınıfı yazarsınız, her tip için kullanırsınız.


 */

/*
public class Repository<T> where T : class // T sınıfı olmalı
{
    private List<T> items = new List<T>();
    public void Add(T item)
    {
        items.Add(item);
    }
    public void Remove(T item)
    {
        items.Remove(item);
    }
    public List<T> GetAll()
    {
        return items;
    }
}

public class Customer
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        var customerRepo = new Repository<Customer>();
        customerRepo.Add(new Customer { Name = "Ahmet" });
        customerRepo.Add(new Customer { Name = "Zeynep" });

        foreach (var c in customerRepo.GetAll())
            Console.WriteLine($"Customer: {c.Name}");
    }
}

*/
#endregion

#region Generic Method
/*
 Generic metotlar, belirli bir veri tipiyle çalışabilen metotlar tanımlamamıza olanak sağlar. Örneğin, bir listeyi sıralamak için generic bir metot yazabilirsiniz. Bu metot, int, string gibi farklı veri tipleriyle çalışabilir.
*/
class Program
{
    public static T Square<T>(T number) where T : struct
    {
        dynamic num = number; // dynamic kullanarak T'yi dinamik hale getiriyoruz
        return num * num;
    }

    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    static void Main()
    {
        int intResult = Square(5);
        double doubleResult = Square(5.5);
        Console.WriteLine($"Square of 5: {intResult}");
        Console.WriteLine($"Square of 5.5: {doubleResult}");

        Console.WriteLine(Max(36,69));


        int intVal = 5;
        double doubleVal = 4.2;
        decimal decimalVal = 7.1m;

        Console.WriteLine($"Square of {intVal}: {Square(intVal)}");
        Console.WriteLine($"Square of {doubleVal}: {Square(doubleVal)}");
        Console.WriteLine($"Square of {decimalVal}: {Square(decimalVal)}");

        Console.WriteLine($"\nMax of {intVal} and 9: {Max(intVal, 9)}");
        Console.WriteLine($"Max of {doubleVal} and 8.9: {Max(doubleVal, 8.9)}");

        var arr = new double[] { 1.1, 2.2, 3.3 };
        Console.WriteLine($"\nSum of array: {SumArray(arr)}");
    }


    public static T SumArray<T>(T[] array) where T : struct, IConvertible
    {
        double sum = 0;
        foreach (var item in array)
            sum += Convert.ToDouble(item);
        return (T)Convert.ChangeType(sum, typeof(T));
    }

}
#endregion