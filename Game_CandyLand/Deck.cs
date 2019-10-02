//-----------------------------------------------------------------------
// <copyright file="Deck.cs" company="Ian Burroughs, Mike B, Triple B & Schulze">
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
    using System.Windows.Forms;

    /// <summary>
    /// Class representing the card deck.
    /// </summary>
    public class Deck
    {
        // todo pass Current Card and/or pickedCard
        // todo uncomment CurrentPlayerTurn Call method call and MovePlayer method call.

        /// <summary>
        /// Current Card field.
        /// </summary>
        private string currentCard;

        /// <summary>
        /// Array to hold the cards in the deck that have been used.
        /// </summary>
        private string[] cardsUsed = new string[66];

        /// <summary>
        /// Array to hold the cards in the deck.
        /// </summary>
        private string[] cards =
        {
            "Green", "Green", "Green", "Green", "Green", "Green", "Green", "Green", "Double Green",
            "Double Green", "Red", "Red", "Red", "Red", "Red", "Red", "Red", "Red", "Double Red", "Double Red",
            "Orange", "Orange", "Orange", "Orange", "Orange", "Orange", "Orange", "Orange", "Double Orange", "Double Orange",
            "Blue", "Blue", "Blue", "Blue", "Blue", "Blue", "Blue", "Blue", "Double Blue", "Double Blue",
            "Purple", "Purple", "Purple", "Purple", "Purple", "Purple", "Purple", "Purple", "Double Purple", "Double Purple",
            "Yellow", "Yellow", "Yellow", "Yellow", "Yellow", "Yellow", "Yellow", "Yellow", "Double Yellow", "Double Yellow",
            "Candy Cane", "Peanut Brittle", "Lolly", "Princess Frostine", "Gumdrop", "GingerbreadMan"
        };

        /// <summary>
        /// Gets or sets CurrentCard.
        /// </summary>
        public string CurrentCard
        {
            get { return this.currentCard; }
            set { this.currentCard = value; }
        }

        /// <summary>
        /// Gets or sets Cards.
        /// </summary>
        public string[] Cards
        {
            get { return this.cards; }
            set { this.cards = value; }
        }

        /// <summary>
        /// Gets or sets CardsUsed.
        /// </summary>
        public string[] CardsUsed
        {
            get { return this.cardsUsed; }
            set { this.cardsUsed = value; }
        }

        /// <summary>
        /// Draw method for the deck class.
        /// </summary>
        /// /// <returns>The picked card for that turn.</returns>
        public string Draw()
        {
            // Check current player property. -- check player method
            // CurrentPlayerTurn();
            //
            // Generate random number between 0 and Cards.length.
            Random yourCard = new Random();
            int thisCard = yourCard.Next(66);

            // Declare a variable for the picked card.
            string pickedCard;

            // Declare a variable for the full element counter.
            int counter;
            int fullCounter = 0;

            // Loop through the array checking for null elements. 
            for (counter = 0; counter < this.CardsUsed.Length; counter++)
            {
                if (this.CardsUsed[counter] != null)
                {
                    // Increment the full counter if element is not null.
                    fullCounter++;
                }
                else
                {
                    // Element is null and array is not full.
                }
            }

            // Compare the counter with the full counter.
            if (fullCounter != counter)
            {
                // CardsUsed array is not full and a new card can be drawn.
                // Check the CardsUsed array to see if corresponding element is null.
                while (this.CardsUsed[thisCard] != null)
                {
                    // If not null generate another random number and check again.
                    thisCard = yourCard.Next(66);
                }

                // Once null grab the string value out of Cards array.
                pickedCard = this.Cards[thisCard];

                // Add element to CardsUsed array.
                this.CardsUsed[thisCard] = pickedCard;

                // Set CurrentCard equal to pickedCard.
                this.CurrentCard = pickedCard;

                // Return pickedCard for draw card method.
                return pickedCard;
            }
            else
            {
                // CardsUsed array is full.
                // Reset the CardsUsed array to null.
                for (int index1 = 0; index1 < this.CardsUsed.Length; index1++)
                {
                    this.CardsUsed[index1] = null;
                }

                // Draw a card.
                thisCard = yourCard.Next(66);

                // Grab the string value out of Cards array.
                pickedCard = this.Cards[thisCard];

                // Add element to CardsUsed array.
                this.CardsUsed[thisCard] = pickedCard;

                // Set CurrentCard equal to pickedCard.
                this.CurrentCard = pickedCard;

                // Return pickedCard for draw card method.
                return pickedCard;
            }
        }
    }
}
