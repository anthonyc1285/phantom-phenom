using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGame
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, jumping, IsGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            player.Top += jumpSpeed;

            if(goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            
            if(goRight == true)
            {
                player.Left += playerSpeed;
            }

            if(jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    

                    if((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;
                        }
                        x.BringToFront();
                    }







                }
            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.Enter && IsGameOver == true)
            {
                RestartGame();
            }

        }

        private void RestartGame()
        {

            jumping = false;
            goLeft = false;
            goRight = false;
            IsGameOver = false;
            score = 0;

            txtScore.Text = "Score: " + score;

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            //reset the position of player, platform, and enemies

            player.Left = 55;
            player.Top = 1141;

            enemy1.Left = 692;
            enemy1.Top =  743;

            enemy2.Left = 653;
            enemy2.Top =  1036;

            horizontalplatform.Left = 313; 
            verticalplatform.Top = 537;

            gameTimer.Start();

        }
    }
}
