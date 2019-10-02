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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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
    }
}
