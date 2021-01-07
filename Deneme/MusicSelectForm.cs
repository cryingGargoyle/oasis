using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Deneme
{
    public partial class MusicSelectForm : Form
    {

        WMPLib.WindowsMediaPlayer rainPlayer = new WMPLib.WindowsMediaPlayer();
        Boolean rainFlag = false;
        WMPLib.WindowsMediaPlayer sPlayer = new WMPLib.WindowsMediaPlayer();
        bool muteSound = false;
        String[] soundLocs;

        int soundIndex;
        int[] durations;
        String[] musicName;
        String[] musicGroup;

        public MusicSelectForm()
        {
            InitializeComponent();
        }

        public void handleNextSound(int soundIndexFunc)
        {
            timer2.Stop();
            timer2.Interval = durations[soundIndexFunc];
            sPlayer.controls.stop();
            sPlayer.URL = soundLocs[soundIndexFunc];
            sPlayer.controls.play();
            sPlayer.settings.volume = musicTrackBar.Value * 5;
            this.mainForm.playingMusicLabel.Text = musicName[soundIndexFunc];
            this.mainForm.playingGroupLabel.Text = musicGroup[soundIndexFunc];
            soundIndex++;
            timer2.Start();
        }

        private Form1 mainForm = null;
        public MusicSelectForm(Form callingForm)
        {
            soundLocs = new String[5] { "Lost Dreams.wav", "Resonance.wav", "Self-Discovery.wav", "Wii Music.wav", "Windows96.wav" };
            soundIndex = 0;
            durations = new int[5] { 158400, 202200, 135600, 78600, 312600 };
            musicName = new String[5] { "Lost Dreams", "Resonance", "Self-Discovery", "Wii Music", "Caligula" };
            musicGroup = new String[5] { "Infinity Frequencies", "Home", "luxury elite", "Nintendo", "Windows96"};
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void MusicSelectForm_Load(object sender, EventArgs e)
        {
            
        }

        private void music1ButtonL_Click(object sender, EventArgs e)
        {
            musicTrackBar.Enabled = true;
            //sPlayer.controls.stop();
            //sPlayer.URL = "Lost Dreams.wav";
            this.mainForm.playingMusicLabel.Text = "Lost Dreams";
            this.mainForm.playingGroupLabel.Text = "Infinity Frequencies";
            //sPlayer.controls.play();
            soundIndex = 0;
            handleNextSound(0);
        }

        private void music2ButtonL_Click(object sender, EventArgs e)
        {
            musicTrackBar.Enabled = true;
            //sPlayer.controls.stop();
            //sPlayer.URL = "Resonance.wav";
            this.mainForm.playingMusicLabel.Text = "Resonance";
            this.mainForm.playingGroupLabel.Text = "Home";
            //sPlayer.controls.play();
            soundIndex = 1;
            handleNextSound(1);
        }

        private void music3ButtonL_Click(object sender, EventArgs e)
        {
            musicTrackBar.Enabled = true;
            //sPlayer.controls.stop();
            //sPlayer.URL = "Self-Discovery.wav";
            this.mainForm.playingMusicLabel.Text = "Self-Discovery";
            this.mainForm.playingGroupLabel.Text = "luxury elite";
            //sPlayer.controls.play();
            soundIndex = 2;
            handleNextSound(2);
        }

        private void music4ButtonL_Click(object sender, EventArgs e)
        {
            musicTrackBar.Enabled = true;
            //sPlayer.controls.stop();
            //sPlayer.URL = "Wii Music.wav";
            this.mainForm.playingMusicLabel.Text = "Wii Music";
            this.mainForm.playingGroupLabel.Text = "Nintendo";
            //sPlayer.controls.play();
            soundIndex = 3;
            handleNextSound(3);
        }

        private void music5ButtonL_Click(object sender, EventArgs e)
        {
            musicTrackBar.Enabled = true;
            //sPlayer.controls.stop();
            //sPlayer.URL = "Windows96.wav";
            this.mainForm.playingMusicLabel.Text = "Caligula";
            this.mainForm.playingGroupLabel.Text = "Windows96";
            //sPlayer.controls.play();
            soundIndex = 4;
            handleNextSound(4);
        }

        private void musicFormHideButtonL_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void rainButtonL_Click(object sender, EventArgs e)
        {
            if (rainFlag)
            {
                this.mainForm.hideRainButton.Visible = true;
                rainFlag = false;
                rainPlayer.controls.stop();
                rainTrackBar.Enabled = false;
            } else
            {
                this.mainForm.hideRainButton.Visible = false;
                rainFlag = true;
                rainTrackBar.Enabled = true;
                rainPlayer.settings.volume = 10;
                rainPlayer.URL = "Rain.mp3";
                rainPlayer.controls.play();
            }
        }

        private void musicTrackBar_Scroll(object sender, EventArgs e)
        {

            sPlayer.settings.volume = musicTrackBar.Value * 5;
        }

        private void rainTrackBar_Scroll(object sender, EventArgs e)
        {
            rainPlayer.settings.volume = rainTrackBar.Value* 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            handleNextSound((soundIndex) % 5);

        }

        private void muteMusicButton_Click(object sender, EventArgs e)
        {
            if (muteSound)
            {
                muteMusicButton.BackgroundImage = null;
                musicTrackBar.Enabled = true;
                sPlayer.settings.volume = musicTrackBar.Value * 5;
                muteSound = false;
            } 
            else
            {
                muteMusicButton.BackgroundImage = Properties.Resources.mutedButton;
                musicTrackBar.Enabled = false;
                sPlayer.settings.volume = 0;
                muteSound = true;
            }
        }
    }
}
