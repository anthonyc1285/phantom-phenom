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

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score + Environment.NewLine + "Collect all coins";

            player.Top += jumpSpeed;

            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true)
            {
                player.Left += playerSpeed;
            }

            if (jumping == true && force < 0)
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
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;

                            if ((string)x.Name == "horizontalplatform" && goLeft == false || (string)x.Name == "horizontalplatform" && goRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }
                        }
                        x.BringToFront();
                    }


                    if ((string)x.Tag == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score += 100;
                        }
                    }

                    if ((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            
                            IsGameOver = true;
                            txtScore.Text = "Score: " + score + Environment.NewLine + "Game Over!";
                            gameTimer.Stop();

                        }
                    }
                }
            }

                horizontalplatform.Left -= horizontalSpeed;

                if (horizontalplatform.Left < 0 || horizontalplatform.Left + horizontalplatform.Width > this.ClientSize.Width)
                {
                    horizontalSpeed = -horizontalSpeed;
                }

                verticalplatform.Top += verticalSpeed;

                if (verticalplatform.Top < 220 || verticalplatform.Top > 400)
                {
                    verticalSpeed = -verticalSpeed;
                }

                enemy1.Left -= enemyOneSpeed;
                if (enemy1.Left < pictureBox4.Left || enemy1.Left + enemy1.Width > pictureBox4.Left + pictureBox4.Width)
                {
                    enemyOneSpeed = -enemyOneSpeed;
                }

                enemy2.Left -= enemyTwoSpeed;
                if (enemy2.Left < platform1.Left || enemy2.Left + enemy2.Width > platform1.Left + platform1.Width)
                {
                    enemyTwoSpeed = -enemyTwoSpeed;
                }

            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                
                IsGameOver = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "Game Over!";
                gameTimer.Stop();

            }

            if (player.Left + player.Width > this.ClientSize.Width)
                {
                    player.Left = this.ClientSize.Width - player.Width;
                }

                if (player.Left < 0 || player.Left + player.Width > this.ClientSize.Width)
                {
                    player.Left = 0;
                }

                if (player.Bounds.IntersectsWith(door.Bounds) && score == 1400)
                {
                    IsGameOver = true;
                    txtScore.Text = "Score: " + score + Environment.NewLine + "You've won!";
                    gameTimer.Stop();
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

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            player.Left = 55;
            player.Top = 700;

            horizontalplatform.Left = 313;

            gameTimer.Start();

        }
    }
}
