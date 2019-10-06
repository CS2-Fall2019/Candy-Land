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
    using System.Windows.Forms.VisualStyles;

    /// <summary>
    /// Class to represent the board.
    /// </summary>
    public class Board
    {
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
        /// Gets or sets Locations.
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
    }
}