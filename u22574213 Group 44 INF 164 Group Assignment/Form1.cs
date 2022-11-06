using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        private void gameTimerEvent(object sender, EventArgs e)
        { 
            
            pbxFlappyBird.Top += gravity;
            pbxPipeBottom.Left -= pipeSpeed;
            pbxPipeTop.Left -= pipeSpeed;
            lblScore.Text = "Score: " + score;

            if (pbxPipeBottom.Left < -50)
            {
                pbxPipeBottom.Left = 1000;
                score++;
            }
            if (pbxPipeTop.Left < -80)
            {
                pbxPipeTop.Left = 950;
                score++; 
            }
            if(pbxFlappyBird.Bounds.IntersectsWith(pbxPipeBottom.Bounds) 
                || pbxFlappyBird.Bounds.IntersectsWith(pbxPipeTop.Bounds)
                ||pbxFlappyBird.Bounds.IntersectsWith(pbxGround.Bounds))
            {
                endGame();
            }

            if (pbxFlappyBird.Top<-25)
            {
                endGame();
            }

            if (score> 5)
            {
                pipeSpeed = 15;
            }

        }

        private void gameKeysDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeysUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            MessageBox.Show( "Score: " + score +"\n"+ "Game Over!" );
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } //need help to figure out how to add the start and stop buttons without the game messing up 
}
