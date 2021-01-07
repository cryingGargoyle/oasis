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
    
    public partial class ToDoForm : Form
    {
        String[] notes = new string[5];

        TextBox[] textBoxes;

        bool[] flags;

        Button[] buttons;
        public ToDoForm()
        {
            InitializeComponent();
            textBoxes = new TextBox[5]{textBox1, textBox2, textBox3, textBox4, textBox5};
            flags = new bool[5] { false, false, false, false, false };
            buttons = new Button[5] {checkButton1, checkButton2, checkButton3, checkButton4, checkButton5 };
        }

        private void checkButton1_Click(object sender, EventArgs e)
        {
            if(flags[0])
            {
                flags[0] = false;
                checkButton1.BackgroundImage = null;
            } else
            {
              flags[0] = true;
              checkButton1.BackgroundImage = Properties.Resources.checkedButton2;
            }

        }

        private void checkButton2_Click(object sender, EventArgs e)
        {
            if (flags[1])
            {
                flags[1] = false;
                checkButton2.BackgroundImage = null;
            }
            else
            {
                flags[1] = true;
                checkButton2.BackgroundImage = Properties.Resources.checkedButton2;
            }
        }

        private void checkButton3_Click(object sender, EventArgs e)
        {
            if (flags[2])
            {
                flags[2] = false;
                checkButton3.BackgroundImage = null;
            }
            else
            {
                flags[2] = true;
                checkButton3.BackgroundImage = Properties.Resources.checkedButton2;
            }
        }

        private void checkButton4_Click(object sender, EventArgs e)
        {
            if (flags[3])
            {
                flags[3] = false;
                checkButton4.BackgroundImage = null;
            }
            else
            {
                flags[3] = true;
                checkButton4.BackgroundImage = Properties.Resources.checkedButton2;
            }
        }

        private void checkButton5_Click(object sender, EventArgs e)
        {
            if (flags[4])
            {
                flags[4] = false;
                checkButton5.BackgroundImage = null;
            }
            else
            {
                flags[4] = true;
                checkButton5.BackgroundImage = Properties.Resources.checkedButton2;
            }
        }

        private void saveButtonL_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                notes[i] = textBoxes[i].Text;
            }
        }

        private void clearButtonL_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                textBoxes[i].Text = "";
                notes[i] = "";
                buttons[i].BackgroundImage = null;
                flags[i] = false;
            }
        }

        private void exitButtonL_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
