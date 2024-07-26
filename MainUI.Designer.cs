
namespace Devil_Tune
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.@__backPnl = new System.Windows.Forms.Panel();
            this.lastSong = new System.Windows.Forms.Panel();
            this.nextSong = new System.Windows.Forms.Panel();
            this.playPauseBtn = new System.Windows.Forms.Panel();
            this.songName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusLbl = new System.Windows.Forms.Label();
            this.playbackTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playbackTimePnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.@__formMover = new System.Windows.Forms.Panel();
            this.timeUpdater = new System.Windows.Forms.Timer(this.components);
            this.@__backPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // __backPnl
            // 
            this.@__backPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.@__backPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.@__backPnl.Controls.Add(this.lastSong);
            this.@__backPnl.Controls.Add(this.nextSong);
            this.@__backPnl.Controls.Add(this.playPauseBtn);
            this.@__backPnl.Controls.Add(this.songName);
            this.@__backPnl.Controls.Add(this.label4);
            this.@__backPnl.Controls.Add(this.panel2);
            this.@__backPnl.Controls.Add(this.statusLbl);
            this.@__backPnl.Controls.Add(this.playbackTime);
            this.@__backPnl.Controls.Add(this.panel1);
            this.@__backPnl.Controls.Add(this.label2);
            this.@__backPnl.Controls.Add(this.label1);
            this.@__backPnl.Controls.Add(this.@__formMover);
            this.@__backPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__backPnl.Location = new System.Drawing.Point(0, 0);
            this.@__backPnl.Name = "__backPnl";
            this.@__backPnl.Size = new System.Drawing.Size(390, 661);
            this.@__backPnl.TabIndex = 0;
            // 
            // lastSong
            // 
            this.lastSong.BackColor = System.Drawing.Color.Transparent;
            this.lastSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lastSong.BackgroundImage")));
            this.lastSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lastSong.Location = new System.Drawing.Point(108, 440);
            this.lastSong.Name = "lastSong";
            this.lastSong.Size = new System.Drawing.Size(37, 50);
            this.lastSong.TabIndex = 12;
            this.lastSong.Click += new System.EventHandler(this.lastSong_Click);
            // 
            // nextSong
            // 
            this.nextSong.BackColor = System.Drawing.Color.Transparent;
            this.nextSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextSong.BackgroundImage")));
            this.nextSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextSong.Location = new System.Drawing.Point(236, 440);
            this.nextSong.Name = "nextSong";
            this.nextSong.Size = new System.Drawing.Size(37, 50);
            this.nextSong.TabIndex = 11;
            this.nextSong.Click += new System.EventHandler(this.nextSong_Click);
            // 
            // playPauseBtn
            // 
            this.playPauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.playPauseBtn.BackgroundImage = global::Devil_Tune.Properties.Resources.play_button_circled_240px;
            this.playPauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playPauseBtn.Location = new System.Drawing.Point(166, 440);
            this.playPauseBtn.Name = "playPauseBtn";
            this.playPauseBtn.Size = new System.Drawing.Size(50, 50);
            this.playPauseBtn.TabIndex = 9;
            this.playPauseBtn.Click += new System.EventHandler(this.playPauseBtn_Click_1);
            // 
            // songName
            // 
            this.songName.BackColor = System.Drawing.Color.Transparent;
            this.songName.Font = new System.Drawing.Font("Montserrat", 13F);
            this.songName.ForeColor = System.Drawing.Color.White;
            this.songName.Location = new System.Drawing.Point(33, 279);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(319, 134);
            this.songName.TabIndex = 10;
            this.songName.Text = "Song Name";
            this.songName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(131, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Now Playing";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(122, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 152);
            this.panel2.TabIndex = 8;
            // 
            // statusLbl
            // 
            this.statusLbl.BackColor = System.Drawing.Color.Transparent;
            this.statusLbl.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.Color.Gray;
            this.statusLbl.Location = new System.Drawing.Point(43, 548);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(300, 17);
            this.statusLbl.TabIndex = 6;
            this.statusLbl.Text = "Idle";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playbackTime
            // 
            this.playbackTime.AutoSize = true;
            this.playbackTime.BackColor = System.Drawing.Color.Transparent;
            this.playbackTime.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbackTime.ForeColor = System.Drawing.Color.White;
            this.playbackTime.Location = new System.Drawing.Point(40, 520);
            this.playbackTime.Name = "playbackTime";
            this.playbackTime.Size = new System.Drawing.Size(37, 15);
            this.playbackTime.TabIndex = 3;
            this.playbackTime.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.playbackTimePnl);
            this.panel1.Location = new System.Drawing.Point(43, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 7);
            this.panel1.TabIndex = 2;
            // 
            // playbackTimePnl
            // 
            this.playbackTimePnl.BackColor = System.Drawing.Color.Tomato;
            this.playbackTimePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.playbackTimePnl.Location = new System.Drawing.Point(0, 0);
            this.playbackTimePnl.Name = "playbackTimePnl";
            this.playbackTimePnl.Size = new System.Drawing.Size(1, 7);
            this.playbackTimePnl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.02F);
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(35, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "⚫";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "⚫";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // __formMover
            // 
            this.@__formMover.BackColor = System.Drawing.Color.Transparent;
            this.@__formMover.Dock = System.Windows.Forms.DockStyle.Top;
            this.@__formMover.Location = new System.Drawing.Point(0, 0);
            this.@__formMover.Name = "__formMover";
            this.@__formMover.Size = new System.Drawing.Size(388, 38);
            this.@__formMover.TabIndex = 7;
            // 
            // timeUpdater
            // 
            this.timeUpdater.Enabled = true;
            this.timeUpdater.Interval = 500;
            this.timeUpdater.Tick += new System.EventHandler(this.timeUpdater_Tick);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 661);
            this.Controls.Add(this.@__backPnl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dark Tunes";
            this.@__backPnl.ResumeLayout(false);
            this.@__backPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel __backPnl;
        private System.Windows.Forms.Label playbackTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Panel __formMover;
        private System.Windows.Forms.Panel lastSong;
        private System.Windows.Forms.Panel nextSong;
        private System.Windows.Forms.Panel playPauseBtn;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel playbackTimePnl;
        private System.Windows.Forms.Timer timeUpdater;
    }
}

