namespace RobotGame.Application.Interfaces
{
    public interface IRobot : IPlayable, IChargeable
    {
        ushort BatteryLife { get; }
        string Name { get; set; }
    }
}
