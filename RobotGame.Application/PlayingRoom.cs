using RobotGame.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RobotGame.Application
{
    /// <summary>
    /// This is where the robots have fun.
    /// </summary>
    public class PlayingRoom : Room, IPlayable
    {
        public event EventHandler DonePlaying;

        /// <summary>
        /// Number of games to play at once.
        /// </summary>
        public static uint GamesPerPlay { get; set; } = 10;

        public PlayingRoom(string name) : base(name)
        {
        }

        /// <summary>
        /// Fires the DonePlaying event.
        /// </summary>
        protected virtual void FireDonePlaying()
        {
            DonePlaying?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Commands all robots in the current room to play
        /// different games at once.
        /// 
        /// <note type="note">
        /// Every game has its own execution thread.
        /// </note>
        /// </summary>
        public void Play()
        {
            var threads = new List<Thread>();
            if (this._robots.Any())
            {
                this.IsBusy = true;

                for (int i = 0; i < GamesPerPlay; i++)
                {
                    var thread = new Thread(() =>
                    {
                        foreach (var player in _robots)
                        {
                            if (player.BatteryLife > 0)
                            {
                                player.Play();
                            }
                        }
                    });

                    thread.IsBackground = true;
                    thread.Start();
                    threads.Add(thread);
                }

                threads.ForEach(t => t.Join());
            }

            FireDonePlaying();
            this.IsBusy = false;
        }
    }
}
