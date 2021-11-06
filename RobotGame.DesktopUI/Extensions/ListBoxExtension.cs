using RobotGame.Application.Interfaces;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RobotGame.DesktopUI.Extensions
{
    internal static class ListBoxExtension
    {
        /// <summary>
        /// Displays robots in a listbox.
        /// </summary>
        /// <param name="listbox">The listbox to display on</param>
        /// <param name="robots">The list of robots to display</param>
        public static void DisplayRobots(this ListBox listbox, IReadOnlyCollection<IRobot> robots)
        {
            listbox.Items.Clear();
            foreach (var robot in robots)
            {
                listbox.Items.Add($"Name : {robot.Name} | Battery Life : {robot.BatteryLife}");
            }
        }
    }
}
