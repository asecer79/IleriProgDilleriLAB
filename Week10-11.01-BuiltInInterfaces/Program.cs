

#region 01-INotifyPropertyChanged

/*
 INotifyPropertyChanged is an interface that provides a standard way to notify clients, typically binding clients, that a property value has changed.
 

 Bir müşteri yönetim uygulaması geliştiriyorsunuz. Müşterinin ismi veya adresi değiştiğinde otomatik olarak loglama yapılmasını istiyorsunuz. Bu özelliği nasıl sağlayabilirsiniz?
 */


/*
using System.ComponentModel;

public class Customer : INotifyPropertyChanged
{
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (_name != value)
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

class Program
{
    static void Main()
    {
        var customer = new Customer();
        customer.PropertyChanged += SendEmail;
        customer.PropertyChanged += Log;

        void Log(object? sender, PropertyChangedEventArgs e)
        {
            if (sender is Customer customer)
            {
                Console.WriteLine($"Property '{e.PropertyName}' changed to '{customer.Name}', ! event was logged");
            }

        }

        customer.Name = "John Doe";
    }

    private static void SendEmail(object? sender, PropertyChangedEventArgs e)
    {
        if (sender is Customer customer)
        {
            Console.WriteLine($"Property '{e.PropertyName}' changed to '{customer.Name}' email was sent");
        }
    }
}

*/

#endregion

#region 02-IComparable, IComparable<T>:

/*
 IComparable and IComparable<T> are interfaces that define a generalized comparison method for objects. 
 They are used to compare two objects and determine their relative order in a collection.
 
 Ürünleri fiyatlarına göre sıralayan bir uygulama geliştiriyorsunuz. Hangi interface'i kullanmalısınız?

*/

/*
class Product:IComparable<Product>
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public int CompareTo(Product? other)
    {
        return Price.CompareTo(other.Price);
    }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1500 },
            new Product { Name = "Mouse", Price = 20 },
            new Product { Name = "Monitor", Price = 200 }
        };

        products.Sort();

        foreach (var product in products)
            Console.WriteLine($"{product.Name}: {product.Price}");
    }
}
*/

#endregion

#region 03-IEquatable<T>:

/*
 IEquatable<T> is an interface that defines a generalized method for comparing instances of the implementing type for equality.
 

İki kullanıcı nesnesinin kullanıcı adı ve email özelliklerinin eşit olduğunu kontrol etmek istiyorsunuz. Nasıl yaparsınız?
*/

/*
class User : IEquatable<User>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Equals(User? other)
    {
        if (other == null) return false;
        return Name == other.Name && Age == other.Age;
    }
}

class Program
{
    static void Main()
    {
        var user1 = new User { Name = "John", Age = 30 };
        var user2 = new User { Name = "John", Age = 30 };
        var user3 = new User { Name = "Jane", Age = 25 };
        Console.WriteLine(user1.Equals(user2)); // True
        Console.WriteLine(user1.Equals(user3)); // False
    }
}

*/
#endregion

#region 04-IEnumerable<T>:

/*
 IEnumerable<T> is an interface that defines a method to obtain an enumerator that iterates through a collection.
 
 Bir koleksiyonun elemanlarını döngü ile gezmek istiyorsunuz. Hangi interface'i kullanmalısınız?
*/

/*
using System.Collections;

class GradeBook : IEnumerable<int>
{
    private List<int> grades = new List<int>();
    public void AddGrade(int grade)
    {
        grades.Add(grade);
    }

    public IEnumerator<int> GetEnumerator()
    {
        foreach (var grade in grades)
        {
            yield return grade;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        var gradeBook = new GradeBook();
        gradeBook.AddGrade(90);
        gradeBook.AddGrade(85);
        gradeBook.AddGrade(78);
        foreach (var grade in gradeBook)
        {
            Console.WriteLine(grade);
        }
    }
}

*/

#endregion


#region 05-IList<T>:
/*
 IList<T> is an interface that represents a collection of objects that can be individually accessed by index.
 
 Bir koleksiyona eleman eklemek, silmek ve erişmek istiyorsunuz. Hangi interface'i kullanmalısınız?
*/

/*
using System.Collections;

class MySpecialList<T>:IList<T> 
{
    private List<T> _items = new List<T>();
    public T this[int index] { get => _items[index]; set => _items[index] = value; }
    public int Count => _items.Count;
    public bool IsReadOnly => false;
    public void Add(T item) => _items.Add(item);
    public void Clear() => _items.Clear();
    public bool Contains(T item) => _items.Contains(item);
    public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
    public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
    public int IndexOf(T item) => _items.IndexOf(item);
    public void Insert(int index, T item) => _items.Insert(index, item);
    public bool Remove(T item) => _items.Remove(item);
    public void RemoveAt(int index) => _items.RemoveAt(index);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();





}

internal class Computer
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Computer(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public override string ToString()
    {
        return $"{Name}: {Price}";
    }
}

class Program
{
    static void Main()
    {
        var computers = new MySpecialList<int>();
       
        foreach (var computer in computers)
            Console.WriteLine(computer);
    }
}
*/
#endregion


#region 06-ICollection<T>:

/*
 ICollection<T> is an interface that defines size, enumerators, and synchronization methods for all generic collections.
 
 Bir koleksiyonun boyutunu öğrenmek istiyorsunuz. Hangi interface'i kullanmalısınız?
*/

/*
using System.Collections;

class MySpecialColection<T>: ICollection<T>
{
    private List<T> _items = new List<T>();
    public int Count => _items.Count;
    public bool IsReadOnly => false;
    public void Add(T item) => _items.Add(item);
    public void Clear() => _items.Clear();
    public bool Contains(T item) => _items.Contains(item);
    public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
    public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
    public bool Remove(T item) => _items.Remove(item);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public void CopyTo(Array array, int index) { }



}


class Program
{
    static void Main()
    {
        var computers = new MySpecialColection<int>();
        computers.Add(1);
        computers.Add(2);
        computers.Add(3);
        Console.WriteLine(computers.Count);
        foreach (var computer in computers)
            Console.WriteLine(computer);
    }
}
*/
#endregion


class Program
{
    static void Main(string[] args)
    {
        
    }
}