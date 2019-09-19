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
    public partial class CandyLandGame : Form
    {
        public CandyLandGame()
        {
            InitializeComponent();
        }

        private void SinglePlayerbutton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();

            //Set up the new form which will be the play area for the game
            PlayerBoard PlayArea = new PlayerBoard();
            PlayArea.Width = 1500;
            PlayArea.Height = 985;
            PlayArea.ShowDialog();

        }

        private void Aboutbutton_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("Developers: Brandon, Ian, James, Mike" + "\n" + "Version: 1.000 " + "\n" + "Date: September 2019", "Game Information");
        }
    }
}
