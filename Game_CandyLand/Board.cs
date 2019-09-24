//-----------------------------------------------------------------------
// <copyright file="Board.cs" company="Ian Burroughs, Mike B, Triple B & Schulze">
//     Copyright (c) Ian Burroughs, Mike B, Biles & Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Game_CandyLand
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class to represent the board.
    /// </summary>
    public class Board
    {
        /// <summary>
        /// Number of Players field.
        /// </summary>
        private int numberOfPlayers; // Change number for final version

        /// <summary>
        /// Round Number field.
        /// </summary>
        private int round;

        /// <summary>
        /// Current Player field.
        /// </summary>
        private int currentPlayer;

        /// <summary>
        /// The Player in first place field.
        /// </summary>
        private int leader;

        /// <summary>
        /// locations array.
        /// </summary>
        private int[] locations = new int[135];

        /// <summary>
        /// Array to hold X coordinates on board.
        /// </summary>
        private int[] locationsX = new int[135];

        /// <summary>
        /// Array to hold Y coordinates on board.
        /// </summary>
        private int[] locationsY = new int[135];

        /// <summary>
        /// Array to hold what color is at what location
        /// </summary>
        private string[] locationsColor = new string[135];

        /// <summary>
        /// Gets or sets Number of Players field.
        /// </summary>
        public int NumberOfPlayers
        {
            get { return this.numberOfPlayers; }
            set { this.numberOfPlayers = value; }
        }

        /// <summary>
        /// Gets or sets Number field.
        /// </summary>
        public int Round
        {
            get { return this.round; }
            set { this.round = value; }
        }

        /// <summary>
        /// Gets or sets Player field.
        /// </summary>
        public int CurrentPlayer
        {
            get { return this.currentPlayer; }
            set { this.currentPlayer = value; }
        }

        /// <summary>
        /// Gets or sets leader field.
        /// </summary>
        public int Leader
        {
            get { return this.leader; }
            set { this.leader = value; }
        }

        /// <summary>
        /// Gets or sets Number of Players field.
        /// </summary>
        public int[] Locations
        {
            get { return this.locations; }
            set { this.locations = value; }
        }

        /// <summary>
        /// Gets or sets locationsX.
        /// </summary>
        public int[] LocationsX
        {
            get { return this.locationsX; }
            set { this.locationsX = value; }
        }

        /// <summary>
        /// Gets or sets locationsY.
        /// </summary>
        public int[] LocationsY
        {
            get { return this.locationsY; }
            set { this.locationsY = value; }
        }

        /// <summary>
        /// Gets or sets locationsColor.
        /// </summary>
        public string[] LocationsColor
        {
            get { return this.locationsColor; }
            set { this.locationsColor = value; }
        }

        // Lose a Turn - will look something like this. so no one is stuck infinitely we only change stuck to true if its false. it should remove after one turn
        /*
        public void LoseATurn(Player)
        {
            if ((player.location == Locations[46] || player.location == Locations[86] || player.location == Locations[117]) && player.stuck == false)
            {
                Player.stuck = true;
            }
            else
            {
            Player.stuck = false;
            }

            if (Player.stuck == true)
            {
                //logic to remove turn here
                //probably remove from 

                // Add 1 to currentPlayer to move to the next player, 
                // if the current player was the last one then move back to the first player.
                if (NumberOfPlayers == 1)
                {
                    // Do nothing because the next player can't be called if there's only one player.
                }
                else if (CurrentPlayer == NumberOfPlayers)
                {
                    CurrentPlayer = 1;
                }
                else
                {
                    CurrentPlayer += 1;
                }

            }
        }
        */

        /*
        /// <summary>
        /// Method to check which players turn it is. 
        /// </summary>
        public void CurrentPlayerTurn()
        {}
        */
    }
}