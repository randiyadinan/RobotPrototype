using RobotPrototype;

ServiceRobot serviceRobot = new ServiceRobot(
    "CareBot",
    10,
    "v1.0",
    "Patient Assistance");

ServiceRobot serviceRobotClone = (ServiceRobot)serviceRobot.Clone();

serviceRobotClone.BatteryCapacity = 15;
serviceRobotClone.SoftwareVersion = "v2.0";

Console.WriteLine("Service Robot");
serviceRobot.DisplayServiceInfo();

Console.WriteLine("\nCloned Service Robot");
serviceRobotClone.DisplayServiceInfo();


IndustrialRobot industrialRobot = new IndustrialRobot(
    "FactoryBot",
    12,
    "v2.0",
    "Welding");

IndustrialRobot industrialRobotClone = (IndustrialRobot)industrialRobot.Clone();

industrialRobotClone.BatteryCapacity = 18;
industrialRobotClone.SoftwareVersion = "v3.0";

Console.WriteLine("\nIndustrial Robot");
industrialRobot.DisplayIndustrialInfo();

Console.WriteLine("\nCloned Industrial Robot");
industrialRobotClone.DisplayIndustrialInfo();


EntertainmentRobot entertainmentRobot = new EntertainmentRobot(
    "FunBot",
    8,
    "v1.5",
    "Dancing and Talking");

EntertainmentRobot entertainmentRobotClone =
    (EntertainmentRobot)entertainmentRobot.Clone();

entertainmentRobotClone.BatteryCapacity = 12;
entertainmentRobotClone.SoftwareVersion = "v2.0";

Console.WriteLine("\nEntertainment Robot");
entertainmentRobot.DisplayEntertainmentInfo();

Console.WriteLine("\nCloned Entertainment Robot");
entertainmentRobotClone.DisplayEntertainmentInfo();