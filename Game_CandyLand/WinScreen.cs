using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_CandyLand
{
    public partial class WinScreen : Form
    {
        public WinScreen()
        {
            InitializeComponent();
        }

        private void WinScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Close this form
            this.Hide();

            // Set up the new form which will be the play area for the game
            PlayerBoard playArea = new PlayerBoard()
            {
                Width = 1500,
                Height = 985
            };

            playArea.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // If exit button is pressed end the application.
            this.Close();
            Application.Exit();
        }

        private void btnNewMultiplayerGame_Click(object sender, EventArgs e)
        {
            // Close this form.
            this.Hide();

            // Create a new instance of the Multiplayer form.
            Multiplayer multiplayerMenu = new Multiplayer();

            // Show the multiplayer menu.
            multiplayerMenu.ShowDialog();
        }
    }
}
