﻿//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
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
    /// Form displayed when the game initially loads.
    /// </summary>
    public partial class CandyLandGame : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CandyLandGame" /> class.
        /// </summary>
        public CandyLandGame()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Method to call the single player game
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnSinglePlayer_Click(object sender, EventArgs e)
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
        /// Method to see the developers, version, and date created.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developers: Brandon, Ian, James, Mike" + "\n" + "Version: 1.000 " + "\n" + "Date: September 2019", "Game Information");
        }

        /// <summary>
        /// Button to open the Multiplayer options form.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnMultiplayer_Click(object sender, EventArgs e)
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
