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
        public string[] LocationsColor = new string[134];

        // Method to move the Player on the board
        public void MovePlayer()
        {


        }

        // Lose a Turn 
        public void LoseATurn(bool stuck)
        {
            if(stuck == true)
            {

            }
            else { }
        }

        public void CurrentPlayerTurn()
        {


        }
    }
}
