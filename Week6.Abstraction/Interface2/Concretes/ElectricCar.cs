using Week6.Abstraction.Interface2.Abstracts;

namespace Week6.Abstraction.Interface2.Concretes;

public class ElectricCar : Vehicle,IVehicle
{
    public int BatteryLevel { get; }
    public void Charge()
    {
        throw new NotImplementedException();
    }

    public int AutoPilotVersion { get; }
    public void EnableAutoPilot()
    {
        throw new NotImplementedException();
    }

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