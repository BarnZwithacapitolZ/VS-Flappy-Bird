using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;


// made by Mr Sam Barnes; HMU

namespace c_game
{
    public partial class Form1 : Form
    {

        //player global variables
        double[] vel = new double[] { 0, 0 };
        double[] pos = new double[] { 0, 0 };
        double[] acc = new double[] { 0, 0 };

        //pipe global variables
        int highScore = 0;
        int score = 0;       
        int gap = 190; //190
        int PipeMinHeight = 150;
        int gapLocation;
        int numPipes = 0;
        int previousNum = 0;
        int pipeWidth = 95;
        int newPipeSpacing = 80;
        Dictionary<int, PictureBox> topPipes = new Dictionary<int, PictureBox>();
        Dictionary<int, PictureBox> bottomPipes = new Dictionary<int, PictureBox>();
        Dictionary<int, PictureBox> gaps = new Dictionary<int, PictureBox>();

        //sounds
        SoundPlayer fly = new SoundPlayer("sfx_wing.wav");
        SoundPlayer die = new SoundPlayer("sfx_hit.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void drawPipe()
        {
            Random r = new Random();
            do
            {
                gapLocation = r.Next(PipeMinHeight, (this.Height - PipeMinHeight) - gap);
            } while (gapLocation <= previousNum + newPipeSpacing && gapLocation >= previousNum);
            previousNum = gapLocation;

            int topPipeLocation = this.Height - gapLocation;
            topPipes[numPipes].Location = new Point(this.Width, 0 - topPipeLocation);
            topPipes[numPipes].Height = this.Height;
       
            bottomPipes[numPipes].Location = new Point(this.Width, gapLocation + gap);
            bottomPipes[numPipes].Height = this.Height;

            gaps[numPipes].Location = new Point(this.Width, gapLocation);
            gaps[numPipes].Height = gap;
        }

        private void checkPipe(Dictionary<int, PictureBox> dict, int pipeNum)
        {
            if (dict.ContainsKey(pipeNum))
            {
                dict[pipeNum].Location = new Point(Convert.ToInt32(dict[pipeNum].Location.X - 1.5), dict[pipeNum].Location.Y);
                if (Player.Bounds.IntersectsWith(dict[pipeNum].Bounds)) { gameOver(); } //GAME OVER
                if (dict.ContainsKey(pipeNum) && dict[pipeNum].Right < 0) { Controls.Remove(dict[pipeNum]); dict.Remove(pipeNum); } //delete pipe when off screen            
            }
        }

        private void gameOver()
        {
            die.Play();
            if (score > highScore) { highScore = score; }          
            score = 0;
            Clock.Enabled = Spawn.Enabled = false;
            for (int x = 0; x < numPipes; x++)
            {
                if (topPipes.ContainsKey(x)) { Controls.Remove(topPipes[x]);  topPipes.Remove(x); }
                if (bottomPipes.ContainsKey(x)) { Controls.Remove(bottomPipes[x]); bottomPipes.Remove(x); }
                if (gaps.ContainsKey(x)) { Controls.Remove(gaps[x]); gaps.Remove(x); }                   
            }
            // 260, 343
            pos[0] = 273;
            pos[1] = 263;
            vel[1] = 0;
            Player.Location = new Point(Convert.ToInt32(pos[0]), Convert.ToInt32(pos[1]));
            buttonPlay.Enabled = buttonPlay.Visible = labelTitle.Visible = LabelHighScore.Visible = labelControls.Visible = true;
            labelScore.Text = "Score: " + score;
            LabelHighScore.Text = "Highest Score: " + highScore / 72;
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            pos[0] = Player.Location.X;
            pos[1] = Player.Location.Y;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Music.URL = "sfx_point.wav";
            Music.Ctlcontrols.stop();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            acc[1] = 0.45; // 0.45
            vel[1] += acc[1];
            pos[1] += (vel[1] + 0.55 * acc[1]);

            if (numPipes > 0)
            {
                for (int x = 0; x < numPipes; x++)
                {
                    checkPipe(topPipes, x);
                    checkPipe(bottomPipes, x);
                    if (gaps.ContainsKey(x))
                    {
                        gaps[x].Location = new Point(Convert.ToInt32(gaps[x].Location.X - 1.5), gaps[x].Location.Y);
                        if (Player.Bounds.IntersectsWith(gaps[x].Bounds))
                        {
                            score += 1;
                            labelScore.Text = "Score: " + (score / 72).ToString(); //72
                            if (score % 72 == 0) { Music.Ctlcontrols.play(); }         
                        }
                    }        
                }
            }
            Player.Location = new Point(Convert.ToInt32(pos[0]), Convert.ToInt32(pos[1]));      
            if (Player.Bounds.IntersectsWith(ptcBottom.Bounds)) { gameOver(); }
            else if (Player.Top < 0) { pos[1] = 0; vel[1] = 0; }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { vel[1] = -10; fly.Play(); }
        }

        private void Spawn_Tick(object sender, EventArgs e)
        {
            PictureBox pipe = new PictureBox(); //top
            Image flipImage = Image.FromFile("pipe.png");
            flipImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            pipe.BackgroundImage = flipImage;
            pipe.BackgroundImageLayout = ImageLayout.Stretch;
            pipe.Width = pipeWidth;           
            Controls.Add(pipe);
            topPipes[numPipes] = pipe;

            PictureBox pipe1 = new PictureBox(); //bottom
            pipe1.BackgroundImage = Image.FromFile("pipe.png");
            pipe1.BackgroundImageLayout = ImageLayout.Stretch;
            pipe1.Width = pipeWidth;         
            Controls.Add(pipe1);
            bottomPipes[numPipes] = pipe1;

            PictureBox pipeGap = new PictureBox(); //gap
            pipeGap.BackColor = Color.Transparent;
            pipeGap.Width = pipeWidth;
            Controls.Add(pipeGap);
            gaps[numPipes] = pipeGap;

            drawPipe();
            numPipes += 1;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            numPipes = 0;
            buttonPlay.Enabled = buttonPlay.Visible = labelTitle.Visible = LabelHighScore.Visible = labelControls.Visible = false;
            Spawn.Enabled = Clock.Enabled = true;
        }

        private void Ground_Tick(object sender, EventArgs e)
        {
            ptcBottom.Location = new Point(Convert.ToInt32(ptcBottom.Location.X - 1.5), ptcBottom.Location.Y);
            if (ptcBottom.Location.X <= 0 - this.Width) { ptcBottom.Left = 0; }
        }
    }
}
