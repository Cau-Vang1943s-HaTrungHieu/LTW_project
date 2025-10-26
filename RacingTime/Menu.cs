using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingTime
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Show();
            this.Hide(); // hide the menu while game runs
        }

        private void btnGameMode_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnHowTo_Click(object sender, EventArgs e)
        {
            // Show the HowToPlay panel
            pnlHowToPlay.Visible = true;

            // Optionally hide menu buttons while panel is open
            btnStartGame.Visible = false;
            btnGameMode.Visible = false;
            btnHowTo.Visible = false;
            btnSetting.Visible = false;
            btnSignOut.Visible = false;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {

        }

        private void btnBackFromHowTo_Click(object sender, EventArgs e)
        {
            // Hide the HowToPlay panel
            pnlHowToPlay.Visible = false;

            // Show main menu buttons again
            btnStartGame.Visible = true;
            btnGameMode.Visible = true;
            btnHowTo.Visible = true;
            btnSetting.Visible = true;
            btnSignOut.Visible = true;
        }
    }
}
