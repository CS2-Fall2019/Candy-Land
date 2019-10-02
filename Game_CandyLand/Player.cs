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
        /// Players game image for their piece.
        /// </summary>
        private int gamePiece;

        /// <summary>
        /// Players name
        /// </summary>
        private string name;

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
        /// Gets or sets GamePiece.
        /// </summary>
        public int GamePiece
        {
            get { return this.gamePiece; }
            set { this.gamePiece = value; }
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
    }
}
