namespace Week6.Abstraction.Interface1;

public interface IVehicle
{
    void Start();
    void Stop();
    int Speed { get; set; }
    string Model { get; }
}