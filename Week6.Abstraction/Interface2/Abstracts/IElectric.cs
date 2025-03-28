namespace Week6.Abstraction.Interface2.Abstracts;

public interface IElectric
{
    int BatteryLevel { get; }
    void Charge();
}