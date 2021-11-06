using RobotGame.Application.Exceptions;
using RobotGame.Application.Interfaces;
using System.Threading;

namespace RobotGame.Application
{
    /// <summary>
    /// Plays games that consumes its battery life and can also get charged.
    /// 
    /// <note type="note">
    /// It cannot play if the battery is dead.
    /// </note>
    /// </summary>
    public class Robot : IRobot
    {
        private ushort _batteryLife;
        private readonly object _batteryLifeLock = new object();

        public string Name { get; set; }

        /// <summary>
        /// The maximum value of the battery life.
        /// </summary>
        public static ushort MaxBatteryLifeValue { get; set; } = 10;

        public ushort BatteryLife
        {
            get
            {
                lock (_batteryLifeLock)
                {
                    return _batteryLife;
                }
            }
        }

        public Robot(string name)
        {
            this._batteryLife = MaxBatteryLifeValue;
            this.Name = name;
        }

        /// <summary>
        /// Commands the robot to play for one second.
        /// </summary>
        public void Play()
        {
            if (_batteryLife <= 0)
            {
                throw new DeadBatteryLifeException(this.Name);
            }

            lock (_batteryLifeLock)
            {
                Thread.Sleep(1000);
                _batteryLife--;
            }
        }

        /// <summary>
        /// Commands the robot to get charged for one second.
        /// </summary>
        public void Charge()
        {
            lock (_batteryLifeLock)
            {
                if (_batteryLife < MaxBatteryLifeValue)
                {
                    Thread.Sleep(1000);
                    _batteryLife++;
                }
            }
        }
    }
}
