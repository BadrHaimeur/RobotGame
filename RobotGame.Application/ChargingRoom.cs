using RobotGame.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RobotGame.Application
{
    /// <summary>
    /// This is where robots get charged with electricity.
    /// </summary>
    public class ChargingRoom : Room, IChargeable
    {
        public event EventHandler DoneCharging;

        public ChargingRoom(string name) : base(name)
        {
        }

        public ChargingRoom(string name, IEnumerable<IRobot> robots) : base(name, robots)
        {
        }

        /// <summary>
        /// Fires the DoneCharging event.
        /// </summary>
        protected virtual void FireDoneCharging()
        {
            DoneCharging?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Charges all robots in the current room with electricity.
        /// </summary>
        public void Charge()
        {
            this.IsBusy = true;
            foreach (var player in _robots)
            {
                if (player.BatteryLife < Robot.MaxBatteryLifeValue)
                {
                    player.Charge();
                }
            }

            FireDoneCharging();
            this.IsBusy = false;
        }
    }
}
