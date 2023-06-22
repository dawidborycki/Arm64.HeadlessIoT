 namespace Arm64.HeadlessIoT.Sensors;
 
 public class SensorReading 
 {
    public double Value { get; private set; }

    public DateTime TimeStamp { get; }

    public SensorReading(double value)
    {
        Value = value;
        TimeStamp = DateTime.UtcNow;
    }
 }