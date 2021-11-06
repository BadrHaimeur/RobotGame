using System;

namespace RobotGame.Application.Exceptions
{
    /// <summary>
    /// Raises when the battery life of a robot is equal to zero.
    /// </summary>
    public class DeadBatteryLifeException : Exception
    {
        public DeadBatteryLifeException(string robotName) : base($"{robotName}'s battery is dead!! Please, charge it to play again.")
        {
        }
    }
}
