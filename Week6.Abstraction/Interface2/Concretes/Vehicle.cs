namespace Week6.Abstraction.Interface2.Concretes;

public class Vehicle
{
    public string Brand { get; set; }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Marka: {Brand}");
    }
}