//-----------------------------------------------------------------------
// <copyright file="Deck.cs" company="Triple B & S">
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

    public class Deck
    {
        // Current Card field.
        public int CurrentCard;

        // Cards array.
        string[] Cards = new string[66];

        // Cards used array.
        string[] CardsUsed = new string[66];

        // Draw method.
        public void Draw()
        {
            // Check current player property. -- check player method
           

            Random yourCard = new Random(66);
            int thisCard = 1;

            // Generate random number between 0 and Cards.length.
            

            // Check the CardsUsed array to see if element is null. (Use a while loop)
            
            // If null, grab the string value out of Cards array.

            // If not null, generate another random number and check again.

            // Add element to CardsUsed array.

            // Call the MovePlayer method.

        }
    }
}
