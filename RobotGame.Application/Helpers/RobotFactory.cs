using RobotGame.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RobotGame.Application.Helpers
{
    public class RobotFactory
    {
        /// <summary>
        /// Creates zero or more robot instances.
        /// </summary>
        /// 
        /// <param name="numberOfRobots">
        /// The number of instances to create. It will
        /// create ten instances if not specified.
        /// </param>
        /// 
        /// <returns>A list of robots</returns>
        public static IList<IRobot> Create(uint numberOfRobots = 10)
        {
            var robots = new List<IRobot>();

            if (numberOfRobots > 0)
            {
                for (int i = 1; i <= numberOfRobots; i++)
                {
                    var robotId = Guid.NewGuid().ToString().Split('-')[0];
                    robots.Add(new Robot("Robot-" + robotId));
                }
            }
            
            return robots;
        }
    }
}
