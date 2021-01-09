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
    public partial class informationForm : Form
    {
        public informationForm()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public informationForm(Form callingForm)
        {
            WindowState = FormWindowState.Maximized;
            mainForm = callingForm as Form1;
            InitializeComponent();
        }


        private void informationForm_Load(object sender, EventArgs e)
        {
            this.Focus();

        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
