namespace Arm64.HeadlessIoT.Sensors;

public interface ISensor 
{
    public bool IsActive {get; set;}

    public SensorReading GetCurrentReading(); 
}