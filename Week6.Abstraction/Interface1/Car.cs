namespace Week6.Abstraction.Interface1;

public class Car : IVehicle
{
    private int _speed;
    public string Model { get; private set; }

    public Car(string model)
    {
        Model = model;
    }

    public int Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public void Start()
    {
        Console.WriteLine($"{Model} arabası çalıştırıldı.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Model} arabası durduruldu.");
        Speed = 0;
    }


}