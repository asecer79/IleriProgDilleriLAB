namespace Week6.Abstraction.Interface2.Abstracts;

public interface IAutonomous
{
    int AutoPilotVersion { get; }
    void EnableAutoPilot();
}