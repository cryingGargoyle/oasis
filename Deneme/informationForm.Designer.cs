
namespace Deneme
{
    partial class informationForm
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
            this.closeFormButtonL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeFormButtonL
            // 
            this.closeFormButtonL.BackColor = System.Drawing.Color.Transparent;
            this.closeFormButtonL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeFormButtonL.Location = new System.Drawing.Point(1743, 21);
            this.closeFormButtonL.Name = "closeFormButtonL";
            this.closeFormButtonL.Size = new System.Drawing.Size(150, 162);
            this.closeFormButtonL.TabIndex = 6;
            this.closeFormButtonL.Click += new System.EventHandler(this.closeFormButtonL_Click);
            // 
            // informationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Deneme.Properties.Resources.informationFrame;
            this.ClientSize = new System.Drawing.Size(1919, 1020);
            this.ControlBox = false;
            this.Controls.Add(this.closeFormButtonL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "informationForm";
            this.Text = "informationForm";
            this.Load += new System.EventHandler(this.informationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeFormButtonL;
    }
}