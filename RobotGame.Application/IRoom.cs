using System.Collections.Generic;

namespace RobotGame.Application
{
    public interface IRoom
    {
        bool IsBusy { get; }
        string Name { get; }
        IReadOnlyCollection<IRobot> Robots { get; }

        void GoIn(IEnumerable<IRobot> robots);
        void GoIn(IRobot robot);
        void GoOut(IRobot robot);
    }
}
