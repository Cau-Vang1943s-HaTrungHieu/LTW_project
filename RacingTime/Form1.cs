using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingTime
{
    public partial class Form1 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        // Press
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        // Release
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            score++;

            if (goleft == true && player.Left > 12)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 437)
            {
                player.Left += playerSpeed;
            }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 781)
            {
                roadTrack2.Top = -781;
            }
            if (roadTrack1.Top > 781)
            {
                roadTrack1.Top = -781;
            }

            bot1.Top += trafficSpeed;
            bot2.Top += trafficSpeed;

            if (bot1.Top > 790)
            {
                //bot1.Top = -20;
                changeBots(bot1);
            }
            if (bot2.Top > 790)
            {
                changeBots(bot2);
            }

            if (player.Bounds.IntersectsWith(bot1.Bounds) || player.Bounds.IntersectsWith(bot2.Bounds))
            {
                gameOver();
            }

            if (score > 500 && score < 2000)
            {
                roadSpeed = 20;
                trafficSpeed = 22;
            }
            if (score > 2000)
            {
                trafficSpeed = 27;
                roadSpeed = 25;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeBots(PictureBox tempCar)
        {
            carImage = rand.Next(1, 9); 
            
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.Ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 400) * -1;

            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            btnStart.Visible = true;
            btnStart.Enabled = true;
        }

        private void resetGame()
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            bot1.Top = carPosition.Next(200, 500) * -1;
            bot1.Left = carPosition.Next(5, 200);

            bot2.Top = carPosition.Next(200, 500) * -1;
            bot2.Left = carPosition.Next(245, 422);

            gameTimer.Start();

        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void playSound()
        {
            System.Media.SoundPlayer crashSound = new System.Media.SoundPlayer(Properties.Resources.hit);
            crashSound.Play();
        }
    }
}
