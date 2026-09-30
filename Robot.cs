namespace RobotPrototype;

public abstract class Robot : IRobotPrototype
{
    public string ModelName { get; set; }
    public double BatteryCapacity { get; set; }
    public string SoftwareVersion { get; set; }

    protected Robot(string modelName, double batteryCapacity, string softwareVersion)
    {
        ModelName = modelName;
        BatteryCapacity = batteryCapacity;
        SoftwareVersion = softwareVersion;
    }

    public abstract IRobotPrototype Clone();

    public void DisplayInfo()
    {
        Console.WriteLine($"Model Name: {ModelName}");
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} hours");
        Console.WriteLine($"Software Version: {SoftwareVersion}");
    }
}