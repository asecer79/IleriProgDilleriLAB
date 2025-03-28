namespace Week6.Abstraction.Interface1;

public class Truck : IVehicle
{
    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

    public int Speed { get; set; }
    public string Model { get; }
}