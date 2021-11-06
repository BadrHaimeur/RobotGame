using RobotGame.Application;
using RobotGame.Application.Helpers;
using RobotGame.Application.Interfaces;
using RobotGame.DesktopUI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
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

            Robot.MaxBatteryLifeValue = 50;

            _robots = RobotFactory.Create(20).ToList();
            _chargingRoom = new ChargingRoom("Power Room");
            _playingRoom = new PlayingRoom("Math Room");

            _chargingRoom.DoneCharging += OnDoneCharging;
            _playingRoom.DonePlaying += OnDonePlaying;
        }

        private void OnDonePlaying(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => OnDonePlaying(sender, e)));
            }
            else
            {
                playButton.Enabled = true;
                playingListBox.DisplayRobots(_playingRoom.Robots);
                MessageBox.Show("Done playing", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnDoneCharging(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => OnDoneCharging(sender, e)));
            }
            else
            {
                chargeButton.Enabled = true;
                chargingListBox.DisplayRobots(_chargingRoom.Robots);
                MessageBox.Show("Done charging", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _chargingRoom.GoIn(_robots);
            chargingListBox.DisplayRobots(_chargingRoom.Robots);
        }

        private void MoveRobotsToRoom(
            IRoom sourceRoom,
            ListBox sourceListBox,
            IRoom destinationRoom,
            ListBox destinationListBox)
        {
            sourceRoom.GoOut();
            sourceListBox.Items.Clear();
            destinationRoom.GoIn(_robots);
            destinationListBox.DisplayRobots(destinationRoom.Robots);
        }

        private void moveToPlayingRoomButton_Click(object sender, EventArgs e)
        {
            moveToPlayingRoomButton.Enabled = false;
            moveToChargingRoomButton.Enabled = true;

            MoveRobotsToRoom(_chargingRoom, chargingListBox, _playingRoom, playingListBox);
        }

        private void moveToChargingRoomButton_Click(object sender, EventArgs e)
        {
            moveToPlayingRoomButton.Enabled = true;
            moveToChargingRoomButton.Enabled = false;

            MoveRobotsToRoom(_playingRoom, playingListBox, _chargingRoom, chargingListBox);
        }

        private async void chargeButton_Click(object sender, EventArgs e)
        {
            if (_chargingRoom.Robots.Count > 0)
            {
                chargeButton.Enabled = false;
                await Task.Run(_chargingRoom.Charge);
            }
            else
            {
                MessageBox.Show("Empty Charging room", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void playButton_Click(object sender, EventArgs e)
        {
            if (_playingRoom.Robots.Count > 0)
            {
                playButton.Enabled = false;
                await Task.Run(_playingRoom.Play);
            }
            else
            {
                MessageBox.Show("Empty Charging room", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
