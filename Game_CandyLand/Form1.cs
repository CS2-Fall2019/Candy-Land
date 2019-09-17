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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SinglePlayerbutton_Click(object sender, EventArgs e)
        {
            PlayerBoard PlayArea = new PlayerBoard();
            PlayArea.Width = 1200;
            PlayArea.Height = 1200;
            PlayArea.ShowDialog();
            this.Close();
        }

        private void Aboutbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developers: Brandon, Ian, James, Mike" + "\n" + "Version: 1.000 " + "\n" + "Date: September 2019");
        }
    }
}
