namespace RobotGame.Application
{
    public interface IRobot
    {
        ushort BatteryLife { get; }
        string Name { get; set; }
    }
}
