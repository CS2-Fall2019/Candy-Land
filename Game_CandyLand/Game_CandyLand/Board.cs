//-----------------------------------------------------------------------
// <copyright file="Board.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_CandyLand
{
    class Board
    {
        // Number of Players field.
        public int NumberOfPlayers = 1; //Change number for final version

        // Round number.
        public int Round;

        // Current Players.
        public int CurrentPlayer;

        // The player in first place.
        public int Leader;

        // The number of locations (squares) on the board.
        public int[] Locations = new int[135];
        public  int[] LocationsX = new int[135];
        public int[] LocationsY = new int[135];
        public string[] LocationsColor = new string[135];

        // Method to move the Player on the board


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

        public void CurrentPlayerTurn()
        {


        }
    }
}
