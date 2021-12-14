using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird_lember
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipedown.Left -= pipeSpeed;
            pipeup.Left -= pipeSpeed;

            scoreText.Text = "Score: " + score;

            if (pipedown.Left < -150)
            {
                pipedown.Left = 800;
                score++;

            }
            if (pipeup.Left < -180)
            {
                pipeup.Left = 950;
                score++;

            }

            if(bird.Bounds.IntersectsWith(pipedown.Bounds) ||
              bird.Bounds.IntersectsWith(pipeup.Bounds) ||
              bird.Bounds.IntersectsWith(ground.Bounds)
              )
            {
                endGame();
            }

        }

        private void gamekeisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }



        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        
        }
        private void endGame()
        {

            GameTimer.Stop();
            scoreText.Text += "gege";

        }

    }

}
