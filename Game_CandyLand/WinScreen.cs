//-----------------------------------------------------------------------
// <copyright file="WinScreen.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Game_CandyLand
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Class representing the screen that comes up after winning.
    /// </summary>
    public partial class WinScreen : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinScreen" /> class.
        /// </summary>
        public WinScreen()
        {
            this.InitializeComponent();

            // Play the victory sound.
            System.IO.Stream strVictory = Properties.Resources.move;
            System.Media.SoundPlayer sndVictory = new System.Media.SoundPlayer(strVictory);
            sndVictory.Play();
        }

        /// <summary>
        /// Button to start a new single player game. 
        /// </summary>
        /// /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnNewGame_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Button to Exit out.
        /// </summary>
        /// /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // If exit button is pressed end the application.
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// Button to start a new multiplayer game.
        /// </summary>
        /// /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnNewMultiplayerGame_Click(object sender, EventArgs e)
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
