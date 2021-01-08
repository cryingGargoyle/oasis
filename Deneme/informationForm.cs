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


        private void informationForm_Load(object sender, EventArgs e)
        {
            this.Focus();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }

        private void closeFormButtonL_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }
    }
}
