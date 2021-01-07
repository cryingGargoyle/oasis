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

namespace Deneme
{
    public partial class Form1 : Form
    {
        private int userMinutes = 0;
        private int userSeconds = 0;
        MusicSelectForm musicForm;
        ToDoForm toForm;
        
        public int UserMinutes
        {
            get { return userMinutes; }
            set { userMinutes = value; }
        }
        public int UserSeconds
        {
            get { return userSeconds; }
            set { userSeconds = value; }
        }

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            musicForm = new MusicSelectForm(this);
            toForm = new ToDoForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan time = TimeSpan.FromSeconds(userSeconds);
            string str = time.ToString(@"hh\:mm\:ss");

            countdownLabel.Text = str;
            userSeconds--;

            if (userSeconds == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time is up!");
                countdownLabel.Text = "00:00:00";
                activityLabel.Text = "(Activity)";
            }
        }

        private void timerFormOpenButtonLClick(object sender, EventArgs e)
        {
            mainPicturBox.Focus();
            //timerPanel.Visible = true;

            mainPicturBox.Focus();

            TimerForm f2 = new TimerForm(this);
            f2.Show();
        }

        private void musicFormOpenButtonL_Click(object sender, EventArgs e)
        {
            
            musicForm.Visible = true;
            musicForm.Focus();
        }

        private void notebookFormOpenButtonL_Click(object sender, EventArgs e)
        {
            toForm.Visible = true;
            toForm.Focus();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPicturBox_Click(object sender, EventArgs e)
        {

        }
    }
    
}


