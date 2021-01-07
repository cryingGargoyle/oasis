
namespace Deneme
{
    partial class MusicSelectForm
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
            this.components = new System.ComponentModel.Container();
            this.music1ButtonL = new System.Windows.Forms.Label();
            this.music2ButtonL = new System.Windows.Forms.Label();
            this.music3ButtonL = new System.Windows.Forms.Label();
            this.music4ButtonL = new System.Windows.Forms.Label();
            this.music5ButtonL = new System.Windows.Forms.Label();
            this.musicFormHideButtonL = new System.Windows.Forms.Label();
            this.rainButtonL = new System.Windows.Forms.Label();
            this.musicTrackBar = new System.Windows.Forms.TrackBar();
            this.rainTrackBar = new System.Windows.Forms.TrackBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.muteMusicButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // music1ButtonL
            // 
            this.music1ButtonL.BackColor = System.Drawing.Color.Transparent;
            this.music1ButtonL.Location = new System.Drawing.Point(40, 81);
            this.music1ButtonL.Name = "music1ButtonL";
            this.music1ButtonL.Size = new System.Drawing.Size(340, 49);
            this.music1ButtonL.TabIndex = 0;
            this.music1ButtonL.Click += new System.EventHandler(this.music1ButtonL_Click);
            // 
            // music2ButtonL
            // 
            this.music2ButtonL.BackColor = System.Drawing.Color.Transparent;
            this.music2ButtonL.Location = new System.Drawing.Point(40, 139);
            this.music2ButtonL.Name = "music2ButtonL";
            this.music2ButtonL.Size = new System.Drawing.Size(340, 47);
            this.music2ButtonL.TabIndex = 1;
            this.music2ButtonL.Click += new System.EventHandler(this.music2ButtonL_Click);
            // 
            // music3ButtonL
            // 
            this.music3ButtonL.BackColor = System.Drawing.Color.Transparent;
            this.music3ButtonL.Location = new System.Drawing.Point(40, 195);
            this.music3ButtonL.Name = "music3ButtonL";
            this.music3ButtonL.Size = new System.Drawing.Size(340, 45);
            this.music3ButtonL.TabIndex = 2;
            this.music3ButtonL.Click += new System.EventHandler(this.music3ButtonL_Click);
            // 
            // music4ButtonL
            // 
            this.music4ButtonL.BackColor = System.Drawing.Color.Transparent;
            this.music4ButtonL.Location = new System.Drawing.Point(40, 252);
            this.music4ButtonL.Name = "music4ButtonL";
            this.music4ButtonL.Size = new System.Drawing.Size(340, 45);
            this.music4ButtonL.TabIndex = 3;
            this.music4ButtonL.Click += new System.EventHandler(this.music4ButtonL_Click);
            // 
            // music5ButtonL
            // 
            this.music5ButtonL.BackColor = System.Drawing.Color.Transparent;
            this.music5ButtonL.Location = new System.Drawing.Point(40, 306);
            this.music5ButtonL.Name = "music5ButtonL";
            this.music5ButtonL.Size = new System.Drawing.Size(340, 45);
            this.music5ButtonL.TabIndex = 4;
            this.music5ButtonL.Click += new System.EventHandler(this.music5ButtonL_Click);
            // 
            // musicFormHideButtonL
            // 
            this.musicFormHideButtonL.BackColor = System.Drawing.Color.Transparent;
            this.musicFormHideButtonL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicFormHideButtonL.Location = new System.Drawing.Point(434, 20);
            this.musicFormHideButtonL.Name = "musicFormHideButtonL";
            this.musicFormHideButtonL.Size = new System.Drawing.Size(48, 38);
            this.musicFormHideButtonL.TabIndex = 5;
            this.musicFormHideButtonL.Click += new System.EventHandler(this.musicFormHideButtonL_Click);
            // 
            // rainButtonL
            // 
            this.rainButtonL.BackColor = System.Drawing.Color.Transparent;
            this.rainButtonL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rainButtonL.Location = new System.Drawing.Point(33, 536);
            this.rainButtonL.Name = "rainButtonL";
            this.rainButtonL.Size = new System.Drawing.Size(93, 85);
            this.rainButtonL.TabIndex = 6;
            this.rainButtonL.Click += new System.EventHandler(this.rainButtonL_Click);
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.musicTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicTrackBar.Enabled = false;
            this.musicTrackBar.Location = new System.Drawing.Point(147, 452);
            this.musicTrackBar.Maximum = 20;
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(296, 45);
            this.musicTrackBar.TabIndex = 7;
            this.musicTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.musicTrackBar.Value = 2;
            this.musicTrackBar.Scroll += new System.EventHandler(this.musicTrackBar_Scroll);
            // 
            // rainTrackBar
            // 
            this.rainTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.rainTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rainTrackBar.Enabled = false;
            this.rainTrackBar.Location = new System.Drawing.Point(147, 555);
            this.rainTrackBar.Maximum = 20;
            this.rainTrackBar.Name = "rainTrackBar";
            this.rainTrackBar.Size = new System.Drawing.Size(296, 45);
            this.rainTrackBar.TabIndex = 8;
            this.rainTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.rainTrackBar.Value = 2;
            this.rainTrackBar.Scroll += new System.EventHandler(this.rainTrackBar_Scroll);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // muteMusicButton
            // 
            this.muteMusicButton.BackColor = System.Drawing.Color.Transparent;
            this.muteMusicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteMusicButton.FlatAppearance.BorderSize = 0;
            this.muteMusicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.muteMusicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.muteMusicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteMusicButton.ForeColor = System.Drawing.Color.Transparent;
            this.muteMusicButton.Location = new System.Drawing.Point(31, 433);
            this.muteMusicButton.Name = "muteMusicButton";
            this.muteMusicButton.Size = new System.Drawing.Size(94, 86);
            this.muteMusicButton.TabIndex = 14;
            this.muteMusicButton.TabStop = false;
            this.muteMusicButton.UseVisualStyleBackColor = false;
            this.muteMusicButton.Click += new System.EventHandler(this.muteMusicButton_Click);
            // 
            // MusicSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Deneme.Properties.Resources.PlayerUI;
            this.ClientSize = new System.Drawing.Size(502, 666);
            this.Controls.Add(this.muteMusicButton);
            this.Controls.Add(this.rainTrackBar);
            this.Controls.Add(this.musicTrackBar);
            this.Controls.Add(this.rainButtonL);
            this.Controls.Add(this.musicFormHideButtonL);
            this.Controls.Add(this.music5ButtonL);
            this.Controls.Add(this.music4ButtonL);
            this.Controls.Add(this.music3ButtonL);
            this.Controls.Add(this.music2ButtonL);
            this.Controls.Add(this.music1ButtonL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicSelectForm";
            this.Text = "MusicSelectForm";
            this.Load += new System.EventHandler(this.MusicSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label music1ButtonL;
        private System.Windows.Forms.Label music2ButtonL;
        private System.Windows.Forms.Label music3ButtonL;
        private System.Windows.Forms.Label music4ButtonL;
        private System.Windows.Forms.Label music5ButtonL;
        private System.Windows.Forms.Label musicFormHideButtonL;
        private System.Windows.Forms.Label rainButtonL;
        private System.Windows.Forms.TrackBar musicTrackBar;
        private System.Windows.Forms.TrackBar rainTrackBar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button muteMusicButton;
    }
}