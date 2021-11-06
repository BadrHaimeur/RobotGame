using RobotGame.Application;
using RobotGame.Application.Helpers;
using RobotGame.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotGame.DesktopUI
{
    public partial class MainForm : Form
    {
        private List<IRobot> _robots;
        private PlayingRoom _playingRoom;
        private ChargingRoom _chargingRoom;

        public MainForm()
        {
            InitializeComponent();

            _robots = RobotFactory.Create(20).ToList();
            _chargingRoom = new ChargingRoom("Power Room");
            _playingRoom = new PlayingRoom("Math Room");

            _chargingRoom.DoneCharging += OnDoneCharging;
            _playingRoom.DonePlaying += OnDonePlaying;
        }

        private void OnDonePlaying(object sender, EventArgs e)
        {
        }

        private void OnDoneCharging(object sender, EventArgs e)
        {
        }
    }
}
