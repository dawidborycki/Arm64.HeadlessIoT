namespace Arm64.HeadlessIoT.Sensors;

public class TemperatureSensor : ISensor
{
    private const int minValue = -10;

    private const int maxValue = 40;

    private SensorReading lastKnownReading 
        = new SensorReading(random.Next(minValue, maxValue));

    private static Random random = new();

    public bool IsActive {get; set;} = true;
    
    public SensorReading GetCurrentReading() 
    {
        if(IsActive)
        {
            var currentSensorReading = new SensorReading(random.Next(minValue, maxValue));

            lastKnownReading = currentSensorReading;

            return currentSensorReading;
        }
        else
        {
            return lastKnownReading;
        }
    }    
}