
namespace Deneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainPicturBox = new System.Windows.Forms.PictureBox();
            this.timerFormOpenButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.countdownLabel = new System.Windows.Forms.Label();
            this.musicFormOpenButtonL = new System.Windows.Forms.Label();
            this.playingMusicLabel = new System.Windows.Forms.Label();
            this.playingGroupLabel = new System.Windows.Forms.Label();
            this.notebookFormOpenButtonL = new System.Windows.Forms.Label();
            this.activityLabel = new System.Windows.Forms.Label();
            this.informationButton = new System.Windows.Forms.Button();
            this.hideRainButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicturBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPicturBox
            // 
            this.mainPicturBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPicturBox.Image = global::Deneme.Properties.Resources._yagmur_Son_Hali;
            this.mainPicturBox.Location = new System.Drawing.Point(0, 0);
            this.mainPicturBox.Name = "mainPicturBox";
            this.mainPicturBox.Size = new System.Drawing.Size(1924, 1061);
            this.mainPicturBox.TabIndex = 0;
            this.mainPicturBox.TabStop = false;
            this.mainPicturBox.Click += new System.EventHandler(this.mainPicturBox_Click);
            // 
            // timerFormOpenButton
            // 
            this.timerFormOpenButton.BackColor = System.Drawing.Color.Transparent;
            this.timerFormOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timerFormOpenButton.FlatAppearance.BorderSize = 0;
            this.timerFormOpenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.timerFormOpenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.timerFormOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerFormOpenButton.ForeColor = System.Drawing.Color.Transparent;
            this.timerFormOpenButton.Location = new System.Drawing.Point(1193, 81);
            this.timerFormOpenButton.Name = "timerFormOpenButton";
            this.timerFormOpenButton.Size = new System.Drawing.Size(181, 184);
            this.timerFormOpenButton.TabIndex = 1;
            this.timerFormOpenButton.TabStop = false;
            this.timerFormOpenButton.UseVisualStyleBackColor = false;
            this.timerFormOpenButton.Click += new System.EventHandler(this.timerFormOpenButtonLClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.BackColor = System.Drawing.Color.Transparent;
            this.countdownLabel.Font = new System.Drawing.Font("Bauhaus 93", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.ForeColor = System.Drawing.Color.White;
            this.countdownLabel.Location = new System.Drawing.Point(1440, 15);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(196, 45);
            this.countdownLabel.TabIndex = 2;
            this.countdownLabel.Text = "00:00:00";
            // 
            // musicFormOpenButtonL
            // 
            this.musicFormOpenButtonL.BackColor = System.Drawing.Color.Transparent;
            this.musicFormOpenButtonL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicFormOpenButtonL.Location = new System.Drawing.Point(1036, 892);
            this.musicFormOpenButtonL.Name = "musicFormOpenButtonL";
            this.musicFormOpenButtonL.Size = new System.Drawing.Size(96, 104);
            this.musicFormOpenButtonL.TabIndex = 3;
            this.musicFormOpenButtonL.Click += new System.EventHandler(this.musicFormOpenButtonL_Click);
            // 
            // playingMusicLabel
            // 
            this.playingMusicLabel.AutoSize = true;
            this.playingMusicLabel.BackColor = System.Drawing.Color.Transparent;
            this.playingMusicLabel.Font = new System.Drawing.Font("Bauhaus 93", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playingMusicLabel.ForeColor = System.Drawing.Color.White;
            this.playingMusicLabel.Location = new System.Drawing.Point(1440, 112);
            this.playingMusicLabel.Name = "playingMusicLabel";
            this.playingMusicLabel.Size = new System.Drawing.Size(128, 45);
            this.playingMusicLabel.TabIndex = 4;
            this.playingMusicLabel.Text = "Music";
            // 
            // playingGroupLabel
            // 
            this.playingGroupLabel.AutoSize = true;
            this.playingGroupLabel.BackColor = System.Drawing.Color.Transparent;
            this.playingGroupLabel.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playingGroupLabel.ForeColor = System.Drawing.Color.White;
            this.playingGroupLabel.Location = new System.Drawing.Point(1443, 157);
            this.playingGroupLabel.Name = "playingGroupLabel";
            this.playingGroupLabel.Size = new System.Drawing.Size(90, 30);
            this.playingGroupLabel.TabIndex = 5;
            this.playingGroupLabel.Text = "Group";
            // 
            // notebookFormOpenButtonL
            // 
            this.notebookFormOpenButtonL.BackColor = System.Drawing.Color.Transparent;
            this.notebookFormOpenButtonL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notebookFormOpenButtonL.Font = new System.Drawing.Font("Bauhaus 93", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notebookFormOpenButtonL.ForeColor = System.Drawing.Color.White;
            this.notebookFormOpenButtonL.Location = new System.Drawing.Point(33, 372);
            this.notebookFormOpenButtonL.Name = "notebookFormOpenButtonL";
            this.notebookFormOpenButtonL.Size = new System.Drawing.Size(150, 184);
            this.notebookFormOpenButtonL.TabIndex = 6;
            this.notebookFormOpenButtonL.Click += new System.EventHandler(this.notebookFormOpenButtonL_Click);
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.BackColor = System.Drawing.Color.Transparent;
            this.activityLabel.Font = new System.Drawing.Font("Bauhaus 93", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLabel.ForeColor = System.Drawing.Color.White;
            this.activityLabel.Location = new System.Drawing.Point(1440, 67);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(192, 45);
            this.activityLabel.TabIndex = 7;
            this.activityLabel.Text = "(Activity)";
            // 
            // informationButton
            // 
            this.informationButton.BackColor = System.Drawing.Color.Transparent;
            this.informationButton.BackgroundImage = global::Deneme.Properties.Resources.questionMark3;
            this.informationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.informationButton.FlatAppearance.BorderSize = 0;
            this.informationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.informationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.informationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationButton.ForeColor = System.Drawing.Color.Transparent;
            this.informationButton.Location = new System.Drawing.Point(1844, 121);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(61, 77);
            this.informationButton.TabIndex = 17;
            this.informationButton.TabStop = false;
            this.informationButton.UseVisualStyleBackColor = false;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // hideRainButton
            // 
            this.hideRainButton.BackColor = System.Drawing.Color.Transparent;
            this.hideRainButton.BackgroundImage = global::Deneme.Properties.Resources.windowButton;
            this.hideRainButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.hideRainButton.FlatAppearance.BorderSize = 0;
            this.hideRainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hideRainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hideRainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideRainButton.ForeColor = System.Drawing.Color.Transparent;
            this.hideRainButton.Location = new System.Drawing.Point(208, -1);
            this.hideRainButton.Name = "hideRainButton";
            this.hideRainButton.Size = new System.Drawing.Size(925, 682);
            this.hideRainButton.TabIndex = 15;
            this.hideRainButton.TabStop = false;
            this.hideRainButton.UseVisualStyleBackColor = false;
            this.hideRainButton.Click += new System.EventHandler(this.hideRainButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BackgroundImage = global::Deneme.Properties.Resources.Image005;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.ForeColor = System.Drawing.Color.Transparent;
            this.quitButton.Location = new System.Drawing.Point(1819, 12);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(93, 82);
            this.quitButton.TabIndex = 16;
            this.quitButton.TabStop = false;
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Deneme.Properties.Resources.mainFrame;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.informationButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.hideRainButton);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.notebookFormOpenButtonL);
            this.Controls.Add(this.playingGroupLabel);
            this.Controls.Add(this.playingMusicLabel);
            this.Controls.Add(this.musicFormOpenButtonL);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.timerFormOpenButton);
            this.Controls.Add(this.mainPicturBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicturBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button timerFormOpenButton;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Label musicFormOpenButtonL;
        public System.Windows.Forms.Label playingMusicLabel;
        public System.Windows.Forms.Label playingGroupLabel;
        public System.Windows.Forms.Label notebookFormOpenButtonL;
        public System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.Button informationButton;
        public System.Windows.Forms.Button hideRainButton;
        private System.Windows.Forms.PictureBox mainPicturBox;
        private System.Windows.Forms.Button quitButton;
    }
}

