//-----------------------------------------------------------------------
// <copyright file="Player.cs" company="Triple B & S">
//     Copyright (c) Triple B & S. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Game_CandyLand
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Player
    {
        // Position field.
        public int Position{
            get
            {
                return Position;
            }
            set
            {
                Position = value;
            }
        }

        // Player Number field.
        public int PlayerNumber;

        // Game Piece field.
        public int GamePiece;

        // Name field.
        public string Name;

        // Stuck field.
        public bool Stuck;

        // DisplayPosition method.
        
    }
}
