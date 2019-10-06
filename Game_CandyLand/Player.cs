//-----------------------------------------------------------------------
// <copyright file="Player.cs" company="Ian Burroughs, Mike B, Triple B & Schulze">
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
    /// Player Class
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Players position or last position.
        /// </summary>
        private int position;

        /// <summary>
        /// Boolean to see if the player is on a stuck spot.
        /// </summary>
        private bool stuck;

        /// <summary>
        /// Players playerNumber
        /// </summary>
        private int playerNumber;

        /// <summary>
        /// Players name
        /// </summary>
        private string name;

        /// <summary>
        /// Boolean to see if the players turn is done.
        /// </summary>
        private bool turnDone;

        /// <summary>
        /// Boolean to see if the player is a computer.
        /// </summary>
        private bool isComputer;

        /// <summary>
        /// Gets or sets position.
        /// </summary>
        public int Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        /// <summary>
        /// Gets or sets playerNumber
        /// </summary>
        public int PlayerNumber
        {
            get { return this.playerNumber; }
            set { this.playerNumber = value; }
        }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a player is stuck.
        /// </summary>
        public bool Stuck
        {
            get { return this.stuck; }
            set { this.stuck = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a players turn is done.
        /// </summary>
        public bool TurnDone
        {
            get { return this.turnDone; }
            set { this.turnDone = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a player is a computer or not.
        /// </summary>
        public bool IsComputer
        {
            get { return this.isComputer; }
            set { this.isComputer = value; }
        }
    }
}
