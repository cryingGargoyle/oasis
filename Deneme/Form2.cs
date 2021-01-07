using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }


        private Form1 mainForm = null;
        public TimerForm(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timerMinuteTextBox.MaxLength = 5;
            timerMinuteTextBox.ShortcutsEnabled = false;
        }

        private void timerSetButtonL_Click(object sender, EventArgs e)
        {
            
            if (timerMinuteTextBox.Text == "")
            {
                MessageBox.Show("Please type in a valid value");
                return;
            }

            if (Convert.ToInt32(timerMinuteTextBox.Text) > 1440)
            {
                MessageBox.Show("Please type in a value which is smaller than 1440");
                return;
            }

            this.mainForm.UserMinutes = Convert.ToInt32(timerMinuteTextBox.Text);
            this.mainForm.UserSeconds = this.mainForm.UserMinutes * 60;
            this.mainForm.timer1.Start();
            this.mainForm.activityLabel.Text = timerActivityTextBox.Text;
            this.Visible = false;
        }

        private void timerResetButtonL_Click(object sender, EventArgs e)
        {
            this.mainForm.timer1.Stop();
            this.mainForm.countdownLabel.Text = "00:00:00";
            this.mainForm.activityLabel.Text = "(Activity)";
            this.timerActivityTextBox.Text = "";
            this.timerMinuteTextBox.Text = "";
        }

        private void timerQuitButtonL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerMinuteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }
    }
}
