using Microsoft.AspNetCore.Mvc;
using Arm64.HeadlessIoT.Sensors;

namespace Arm64.HeadlessIoT.Controllers;

[ApiController]
[Route("[controller]")]
public class IoTController : ControllerBase
{           
    private readonly ISensor temperatureSensor;

    public IoTController(ISensor sensor)
    {
        temperatureSensor = sensor;
    }

    [HttpGet]
    [ProducesResponseType(typeof(SensorReading), StatusCodes.Status200OK)]
    public SensorReading Get()
    {
        return temperatureSensor.GetCurrentReading();
    }

    [HttpPost]
    public IActionResult SetSensorStatus(bool isActive)
    {
        temperatureSensor.IsActive = isActive;

        return Ok();
    }
}
