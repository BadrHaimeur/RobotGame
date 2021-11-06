namespace RobotGame.Application
{
    public interface IRobot : IPlayable, IChargeable
    {
        ushort BatteryLife { get; }
        string Name { get; set; }
    }
}
