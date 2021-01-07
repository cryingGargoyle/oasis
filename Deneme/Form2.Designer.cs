
namespace Deneme
{
    partial class TimerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timerQuitButtonL = new System.Windows.Forms.Label();
            this.timerResetButtonL = new System.Windows.Forms.Label();
            this.timerSetButtonL = new System.Windows.Forms.Label();
            this.timerActivityTextBox = new System.Windows.Forms.TextBox();
            this.timerMinuteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timerQuitButtonL
            // 
            this.timerQuitButtonL.BackColor = System.Drawing.Color.Transparent;
            this.timerQuitButtonL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timerQuitButtonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.timerQuitButtonL.ForeColor = System.Drawing.Color.White;
            this.timerQuitButtonL.Location = new System.Drawing.Point(427, 17);
            this.timerQuitButtonL.Name = "timerQuitButtonL";
            this.timerQuitButtonL.Size = new System.Drawing.Size(46, 35);
            this.timerQuitButtonL.TabIndex = 9;
            this.timerQuitButtonL.Click += new System.EventHandler(this.timerQuitButtonL_Click);
            // 
            // timerResetButtonL
            // 
            this.timerResetButtonL.BackColor = System.Drawing.Color.Transparent;
            this.timerResetButtonL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timerResetButtonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.timerResetButtonL.ForeColor = System.Drawing.Color.White;
            this.timerResetButtonL.Location = new System.Drawing.Point(108, 456);
            this.timerResetButtonL.Name = "timerResetButtonL";
            this.timerResetButtonL.Size = new System.Drawing.Size(93, 95);
            this.timerResetButtonL.TabIndex = 8;
            this.timerResetButtonL.Click += new System.EventHandler(this.timerResetButtonL_Click);
            // 
            // timerSetButtonL
            // 
            this.timerSetButtonL.BackColor = System.Drawing.Color.Transparent;
            this.timerSetButtonL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timerSetButtonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.timerSetButtonL.ForeColor = System.Drawing.Color.White;
            this.timerSetButtonL.Location = new System.Drawing.Point(243, 454);
            this.timerSetButtonL.Name = "timerSetButtonL";
            this.timerSetButtonL.Size = new System.Drawing.Size(92, 98);
            this.timerSetButtonL.TabIndex = 7;
            this.timerSetButtonL.Click += new System.EventHandler(this.timerSetButtonL_Click);
            // 
            // timerActivityTextBox
            // 
            this.timerActivityTextBox.BackColor = System.Drawing.Color.White;
            this.timerActivityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timerActivityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.timerActivityTextBox.ForeColor = System.Drawing.Color.Black;
            this.timerActivityTextBox.Location = new System.Drawing.Point(91, 209);
            this.timerActivityTextBox.Name = "timerActivityTextBox";
            this.timerActivityTextBox.Size = new System.Drawing.Size(260, 46);
            this.timerActivityTextBox.TabIndex = 6;
            this.timerActivityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerMinuteTextBox
            // 
            this.timerMinuteTextBox.BackColor = System.Drawing.Color.White;
            this.timerMinuteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timerMinuteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.timerMinuteTextBox.ForeColor = System.Drawing.Color.Black;
            this.timerMinuteTextBox.Location = new System.Drawing.Point(91, 318);
            this.timerMinuteTextBox.Name = "timerMinuteTextBox";
            this.timerMinuteTextBox.Size = new System.Drawing.Size(260, 46);
            this.timerMinuteTextBox.TabIndex = 5;
            this.timerMinuteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timerMinuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timerMinuteTextBox_KeyPress);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Deneme.Properties.Resources.timerUI;
            this.ClientSize = new System.Drawing.Size(488, 617);
            this.ControlBox = false;
            this.Controls.Add(this.timerQuitButtonL);
            this.Controls.Add(this.timerResetButtonL);
            this.Controls.Add(this.timerSetButtonL);
            this.Controls.Add(this.timerActivityTextBox);
            this.Controls.Add(this.timerMinuteTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimerForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timerQuitButtonL;
        private System.Windows.Forms.Label timerResetButtonL;
        private System.Windows.Forms.Label timerSetButtonL;
        private System.Windows.Forms.TextBox timerActivityTextBox;
        private System.Windows.Forms.TextBox timerMinuteTextBox;
    }
}