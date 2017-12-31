namespace c_game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.Spawn = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.LabelHighScore = new System.Windows.Forms.Label();
            this.Music = new AxWMPLib.AxWindowsMediaPlayer();
            this.MusicFall = new AxWMPLib.AxWindowsMediaPlayer();
            this.ptcBottom = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.labelControls = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicFall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Clock
            // 
            this.Clock.Interval = 1;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Spawn
            // 
            this.Spawn.Interval = 3000;
            this.Spawn.Tick += new System.EventHandler(this.Spawn_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(446, 33);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(120, 37);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score: 0";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(153, 127);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(286, 62);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Flappy Bird";
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(237, 346);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(119, 59);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // LabelHighScore
            // 
            this.LabelHighScore.AutoSize = true;
            this.LabelHighScore.BackColor = System.Drawing.Color.Transparent;
            this.LabelHighScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHighScore.Location = new System.Drawing.Point(151, 599);
            this.LabelHighScore.Name = "LabelHighScore";
            this.LabelHighScore.Size = new System.Drawing.Size(310, 48);
            this.LabelHighScore.TabIndex = 4;
            this.LabelHighScore.Text = "Highest Score: 0";
            this.LabelHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Music
            // 
            this.Music.Enabled = true;
            this.Music.Location = new System.Drawing.Point(15, 33);
            this.Music.Name = "Music";
            this.Music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Music.OcxState")));
            this.Music.Size = new System.Drawing.Size(144, 50);
            this.Music.TabIndex = 5;
            this.Music.Visible = false;
            // 
            // MusicFall
            // 
            this.MusicFall.Enabled = true;
            this.MusicFall.Location = new System.Drawing.Point(179, 33);
            this.MusicFall.Name = "MusicFall";
            this.MusicFall.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicFall.OcxState")));
            this.MusicFall.Size = new System.Drawing.Size(144, 50);
            this.MusicFall.TabIndex = 6;
            this.MusicFall.Visible = false;
            // 
            // ptcBottom
            // 
            this.ptcBottom.BackgroundImage = global::c_game.Properties.Resources.floorShort;
            this.ptcBottom.Location = new System.Drawing.Point(-6, 658);
            this.ptcBottom.Name = "ptcBottom";
            this.ptcBottom.Size = new System.Drawing.Size(1508, 105);
            this.ptcBottom.TabIndex = 7;
            this.ptcBottom.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = global::c_game.Properties.Resources.piq_166547_400x4001;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(273, 263);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // labelControls
            // 
            this.labelControls.AutoSize = true;
            this.labelControls.BackColor = System.Drawing.Color.Transparent;
            this.labelControls.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControls.Location = new System.Drawing.Point(141, 433);
            this.labelControls.Name = "labelControls";
            this.labelControls.Size = new System.Drawing.Size(325, 38);
            this.labelControls.TabIndex = 8;
            this.labelControls.Text = "Use Up arrow to jump";
            this.labelControls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ground
            // 
            this.Ground.Enabled = true;
            this.Ground.Interval = 1;
            this.Ground.Tick += new System.EventHandler(this.Ground_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 762);
            this.Controls.Add(this.labelControls);
            this.Controls.Add(this.ptcBottom);
            this.Controls.Add(this.MusicFall);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.LabelHighScore);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicFall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Timer Spawn;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label LabelHighScore;
        private AxWMPLib.AxWindowsMediaPlayer Music;
        private AxWMPLib.AxWindowsMediaPlayer MusicFall;
        private System.Windows.Forms.PictureBox ptcBottom;
        private System.Windows.Forms.Label labelControls;
        private System.Windows.Forms.Timer Ground;
    }
}

