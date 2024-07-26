using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using Dark;

namespace Devil_Tune
{
    public partial class MainUI : Form
    {
        IDictionary<string, string> loadedSongs = new Dictionary<string, string>();
        int curIndex = 0;
        WMPLib.WindowsMediaPlayer ActivePlayer = new WMPLib.WindowsMediaPlayer();

        public MainUI()
        {
            InitializeComponent();
            DarkUXWorker dw = new DarkUXWorker();
            dw.CustomFormMover(__formMover, this);

            songName.Text = "";

            if (!Directory.Exists("resources"))
            {
                Directory.CreateDirectory("resources");
            }

            ActivePlayer.DurationUnitChange += ActivePlayer_DurationUnitChange;

            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://raw.githubusercontent.com/Team-MPA/CaheStorage/main/DevilTunes.txt");
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            foreach (var curDat in content.Split('\n'))
            {
                loadedSongs.Add(curDat.Split('|')[0], curDat.Split('|')[1]);
            }
        }

        private void ActivePlayer_DurationUnitChange(int NewDurationUnit)
        {
            playbackTime.Text = NewDurationUnit.ToString();
            playbackTimePnl.Width = NewDurationUnit;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Tomato;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.Green;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.SpringGreen;
        }

        private void playPauseBtn_Click_1(object sender, EventArgs e)
        {
            if (ActivePlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                ActivePlayer.controls.pause();
                playPauseBtn.BackgroundImage = Properties.Resources.play_button_circled_240px;
                statusLbl.Text = "Paused !";
            }
            else if (ActivePlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                ActivePlayer.controls.play();
                playPauseBtn.BackgroundImage = Properties.Resources.pause;
                statusLbl.Text = "Playing...";
            }
            else if (ActivePlayer.playState == WMPLib.WMPPlayState.wmppsStopped || ActivePlayer.playState == WMPLib.WMPPlayState.wmppsUndefined)
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    using (Stream ms = new MemoryStream())
                    {
                        Invoke(new Action(() =>
                        {
                            statusLbl.Text = "Buffering...";
                            try
                            {
                                songName.Text = loadedSongs.ElementAt(curIndex).Key;
                            }
                            catch(Exception)
                            {
                                curIndex = 0;
                                songName.Text = loadedSongs.ElementAt(curIndex).Key;
                            }
                            
                        }));

                        if (!File.Exists(@"resources\" + loadedSongs.ElementAt(curIndex).Key + ".mp3"))
                        {
                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile(loadedSongs.ElementAt(curIndex).Value, @"resources\" + loadedSongs.ElementAt(curIndex).Key + ".mp3");
                            }
                        }

                        playPauseBtn.BackgroundImage = Properties.Resources.pause;

                        Invoke(new Action(() =>
                        {
                            statusLbl.Text = "Playing...";
                            ActivePlayer.URL = @"resources\" + loadedSongs.ElementAt(curIndex).Key + ".mp3";
                            ActivePlayer.controls.play();
                        }));
                    }

                }).Start();
            }
        }

        private void nextSong_Click(object sender, EventArgs e)
        {
            if (curIndex <= loadedSongs.Count - 2)
            {
                curIndex++;
                ActivePlayer.controls.stop();
                statusLbl.Text = "Idle";
                playPauseBtn_Click_1(sender, e);
            }
        }

        private void lastSong_Click(object sender, EventArgs e)
        {
            if (curIndex >= 1)
            {
                curIndex--;
                ActivePlayer.controls.stop();
                statusLbl.Text = "Idle";
                playPauseBtn_Click_1(sender, e);
            }
        }

        private void timeUpdater_Tick(object sender, EventArgs e)
        {
            if (ActivePlayer.currentMedia != null)
            {
                try
                {
                    playbackTime.Text = ActivePlayer.controls.currentPositionString;
                    playbackTimePnl.Width = Convert.ToInt32((ActivePlayer.controls.currentPosition / ActivePlayer.currentMedia.duration) * 100) * 3;
                }
                catch(Exception)
                {

                }
            }
            GC.Collect();
            Thread.Sleep(10);
        }
    }
}
