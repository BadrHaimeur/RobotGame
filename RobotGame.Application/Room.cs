using RobotGame.Application.Interfaces;
using System.Collections.Generic;

namespace RobotGame.Application
{
    /// <summary>
    /// Gathers robots to do some activities.
    /// 
    /// <note type="note">
    /// All commands will take effect only if there are no activities in the room.
    /// </note>
    /// </summary>
    public class Room : IRoom
    {
        protected List<IRobot> _robots;

        public string Name { get; }
        public bool IsBusy { get; protected set; }
        public IReadOnlyCollection<IRobot> Robots { get => _robots.AsReadOnly(); }

        public Room(string name)
        {
            this.Name = name;
            this._robots = new List<IRobot>();
        }

        /// <summary>
        /// Commands a bunch of robots to enter the current room.
        /// </summary>
        /// <param name="robots">The robots that must enter the room.</param>
        public void GoIn(IEnumerable<IRobot> robots)
        {
            if (!IsBusy)
            {
                _robots.AddRange(robots);
            }
        }

        /// <summary>
        /// Commands one robot to enter the current room.
        /// </summary>
        /// <param name="robot">The robot that must enter the room.</param>
        public void GoIn(IRobot robot)
        {
            if (!IsBusy)
            {
                _robots.Add(robot);
            }
        }

        /// <summary>
        /// Commands one robot or all robots to leave the current room.
        /// </summary>
        /// <param name="robot">
        /// The robot that must leave the room. If it is null,
        /// all robots will leave the room.
        /// </param>
        public void GoOut(IRobot robot = null)
        {
            if (!IsBusy)
            {
                if (robot != null)
                {
                    _robots.Remove(robot);
                }
                else
                {
                    _robots.Clear();
                }

            }
        }
    }
}
