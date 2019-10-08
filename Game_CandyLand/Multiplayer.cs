//-----------------------------------------------------------------------
// <copyright file="Multiplayer.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
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
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Form displayed when the player selects the multiplayer option.
    /// </summary>
    public partial class Multiplayer : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Multiplayer" /> class.
        /// </summary>
        public Multiplayer()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Method to call the multiplayer game.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnStartMultiplayer_Click(object sender, EventArgs e)
        {
            // Create a new player board instance.
            PlayerBoard playBoard = new PlayerBoard()
            {
                Width = 1500,
                Height = 985
            };

            // Set a boolean value to hold true if combo boxes are valid.
            bool validBoxes = false;

            // Boolean value to hold true if players combo box is valid.
            bool validPlayers = false;

            // Boolean value to hold true if computer players combo box is valid.
            bool validComputerPlayers = false;

            // If one of the options for the number of players combo box is selected.
            if (this.cboPlayers.SelectedIndex == 0 || this.cboPlayers.SelectedIndex == 1 ||
                this.cboPlayers.SelectedIndex == 2)
            {
                // Set validPlayers boolean to true.
                validPlayers = true;
            }

            // If one of the options for the number of computer players combo box is selected.
            if (this.cboComputerPlayers.SelectedIndex == 0 || this.cboComputerPlayers.SelectedIndex == 1 ||
                this.cboComputerPlayers.SelectedIndex == 2 || this.cboComputerPlayers.SelectedIndex == 3 ||
                this.cboComputerPlayers.SelectedIndex == 4)
            {
                // Set validComputerPlayers boolean to true.
                validComputerPlayers = true;
            }

            // If both of the individual combo boxes are valid.
            if (validPlayers && validComputerPlayers)
            {
                // Check to make sure that the choices make sense logically. 
                // Set totalPlayers = to the total number of players parsed from the players combo box.
                int totalPlayers = int.Parse(this.cboPlayers.SelectedItem.ToString());

                // Set computerPlayers = to the total number of computer players parsed from the 
                // computer players combo box.
                int computerPlayers = int.Parse(this.cboComputerPlayers.SelectedItem.ToString());

                // If there is an equal or greater amount of total players than computer players.
                if (totalPlayers >= computerPlayers)
                {
                    // Both boxes are valid and make sense logically.
                    // Set validBoxes boolean to true.
                    validBoxes = true;
                }
                else
                {
                    // Error message telling the user there is more computer players than total players.
                    MessageBox.Show("You can't have more computer players than total players." + "\n" +
                                    "Please select a different number of computer or total players.");
                }
            }
            else if (validPlayers && !validComputerPlayers)
            {
                // If none of the options are selected for number of computer players.
                // Error message saying to please select one of the options
                // for the number of computer players.
                MessageBox.Show("Please select one of the options for the number of computer players.");
            }
            else
            {
                // If none of the options are selected for number of players.
                // Error message saying to please select one of the options for the number of players.
                MessageBox.Show("Please select one of the options for the number of players.");
            }

            // If all of the boxes are validated
            if (validBoxes)
            {
                // Set number of players equal to the number picked.
                if (this.cboPlayers.SelectedIndex == 0)
                {
                    // If the option for two is selected.
                    playBoard.NumberOfPlayers = 2;
                }
                else if (this.cboPlayers.SelectedIndex == 1)
                {
                    // If the option for three is selected.
                    playBoard.NumberOfPlayers = 3;
                }
                else
                {
                    // The option for 4 players was selected.
                    playBoard.NumberOfPlayers = 4;
                }

                // Call SetUpPlayerList method.
                playBoard.CreatePlayerList(playBoard.NumberOfPlayers);

                // Set number of players equal to the number picked.
                if (this.cboPlayers.SelectedIndex == 0)
                {
                    // If the option for two is selected.
                    playBoard.NumberOfPlayers = 2;
                }
                else if (this.cboPlayers.SelectedIndex == 1)
                {
                    // If the option for three is selected.
                    playBoard.NumberOfPlayers = 3;
                }
                else
                {
                    // The option for four was selected.
                    playBoard.NumberOfPlayers = 4;
                }

                // Set computer players.
                // If one computer player is selected.
                if (this.cboComputerPlayers.SelectedIndex == 1)
                {
                    if (playBoard.NumberOfPlayers == 2)
                    {
                        // Number of players is 2.
                        // Set 1st element of playerList as computer.
                        playBoard.PlayerList[1].IsComputer = true;
                    }
                    else if (playBoard.NumberOfPlayers == 3)
                    {
                        // Number of players is 3.
                        // Set 2nd element of playerList as computer.
                        playBoard.PlayerList[2].IsComputer = true;
                    }
                    else
                    {
                        // Number of players is 4.
                        // Set 3rd element of playerList as computer.
                        playBoard.PlayerList[3].IsComputer = true;
                    }
                }
                else if (this.cboComputerPlayers.SelectedIndex == 2)
                {
                    // If two computer players are selected.
                    if (playBoard.NumberOfPlayers == 2)
                    {
                        // Number of players is 2.
                        // Set 0th and 1st element of playerList as computer.
                        playBoard.PlayerList[0].IsComputer = true;
                        playBoard.PlayerList[1].IsComputer = true;
                    }
                    else if (playBoard.NumberOfPlayers == 3)
                    {
                        // Number of players is 3.
                        // Set 1st and 2nd element of playerList as computer.
                        playBoard.PlayerList[1].IsComputer = true;
                        playBoard.PlayerList[2].IsComputer = true;
                    }
                    else
                    {
                        // Number of players is 4.
                        // Set 2nd and 3rd element of playerList as computer.
                        playBoard.PlayerList[2].IsComputer = true;
                        playBoard.PlayerList[3].IsComputer = true;
                    }
                }
                else if (this.cboComputerPlayers.SelectedIndex == 3)
                {
                    // If three computer players are selected.
                    if (playBoard.NumberOfPlayers == 3)
                    {
                        // Number of players is 3.
                        // Set 0th, 1st and 2nd elements of playerList as computer.
                        playBoard.PlayerList[0].IsComputer = true;
                        playBoard.PlayerList[1].IsComputer = true;
                        playBoard.PlayerList[2].IsComputer = true;
                    }
                    else
                    {
                        // Number of players is 4.
                        // Set 1st, 2nd and 3rd elements of playerList as computer.
                        playBoard.PlayerList[1].IsComputer = true;
                        playBoard.PlayerList[2].IsComputer = true;
                        playBoard.PlayerList[3].IsComputer = true;
                    }
                }
                else if (this.cboComputerPlayers.SelectedIndex == 4)
                {
                    // All 4 have to be computers.
                    // Set 0th, 1st, 2nd and 3rd elements of playerList as computer.
                    playBoard.PlayerList[0].IsComputer = true;
                    playBoard.PlayerList[1].IsComputer = true;
                    playBoard.PlayerList[2].IsComputer = true;
                    playBoard.PlayerList[3].IsComputer = true;
                }
                else
                {
                    // The option for none was selected.
                    // All players are human and nothing needs to be changed.
                }

                // Hide this form.
                this.Hide();

                // Load the game board.
                playBoard.ShowDialog();
            }
        }
    }
}
