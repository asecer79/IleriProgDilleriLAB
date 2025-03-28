namespace Week6.Abstraction.Interface2.Abstracts;

public interface IVehicle:IElectric, IAutonomous
{
    void Start();
    void Stop();
    int Speed { get; set; }
    string Model { get; }
}