//-----------------------------------------------------------------------
// <copyright file="Deck.cs" company="Triple B & S">
//     Copyright (c) Triple B & S. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Windows.Forms;

namespace Game_CandyLand
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class Deck
    {
        // todo should Current Card be a string not an int?
        // todo Current Card needs to be passed as an element to image list.
        // todo bool value or no for cardsUsed full?
        // todo set CurrentCard = Cards[thisCard] where needed.
        // todo pass that info anywhere?

        // Current Card field.
        public int CurrentCard;

        // Cards array.
        public string[] Cards = {"Green", "Green", "Green", "Green", "Green", "Green", "Green", "Green", "Double Green",
            "Double Green", "Red", "Red", "Red", "Red", "Red", "Red", "Red", "Red", "Double Red", "Double Red",
            "Orange", "Orange", "Orange", "Orange", "Orange", "Orange", "Orange", "Orange", "Double Orange", "Double Orange",
            "Blue", "Blue", "Blue", "Blue", "Blue", "Blue", "Blue", "Blue", "Double Blue", "Double Blue",
            "Purple", "Purple", "Purple", "Purple", "Purple", "Purple", "Purple", "Purple", "Double Purple", "Double Purple",
            "Yellow", "Yellow", "Yellow", "Yellow", "Yellow", "Yellow", "Yellow", "Yellow", "Double Yellow", "Double Yellow",
            "Candy Cane", "Peanut Brittle", "Lolly", "Princess Frostine", "Gumdrop", "Plum"
        };

        // Cards used array.
        public string[] CardsUsed = new string[66];

        //
        //                      
        //
        // Do cards and cards used arrays have to be capitalized? do they have to be public?
        //
        //      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

        // Draw method.
        public void Draw()
        {
            // Check current player property. -- check player method
            // CurrentPlayerTurn();

            // Generate random number between 0 and Cards.length.
            Random yourCard = new Random();
            int thisCard = yourCard.Next(66);

            // Declare a variable for the picked card.
            string pickedCard;

            // Create a boolean value to hold true if cardsUsed array is full, and initialize it to true.
            bool cardsUsedFull = true;

            // Declare a variable for the full element counter.
            int counter;
            int fullCounter = 0;

            // Loop through the array checking for null elements. 
            for (counter = 0; counter < CardsUsed.Length; counter++)
            {
                if (CardsUsed[counter] != null)
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
                while (CardsUsed[thisCard] != null)
                {
                    // If not null generate another random number and check again.
                    thisCard = yourCard.Next(66);
                }

                // Once null grab the string value out of Cards array.
                pickedCard = Cards[thisCard];

                // Add element to CardsUsed array.
                CardsUsed[thisCard] = pickedCard;

                // Call the MovePlayer method.
                // MovePlayer(pickedCard, CurrentPlayer.PlayerNumber ); // Need to get player info from player class.

            }
            else
            {
                // CardsUsed array is full.
                // Reset the CardsUsed array to null.
                for (int index1 = 0; index1 < CardsUsed.Length; index1++)
                {
                    CardsUsed[index1] = null;
                }

                // Draw a card.
                thisCard = yourCard.Next(66);

                // Grab the string value out of Cards array.
                pickedCard = Cards[thisCard];

                // Add element to CardsUsed array.
                CardsUsed[thisCard] = pickedCard;

                // Call the MovePlayer method.
                // MovePlayer(pickedCard); // Need to get player info from player class.

            }

            /*
            if (fullCounter != counter)
            {
                // CardsUsed is not full, bool value is false.
                cardsUsedFull = false;
            }
            else
            {
                // CardsUsed is full, bool value is already true.
            }

            if (!cardsUsedFull)
            {
                // Check the CardsUsed array to see if corresponding element is null.
                while (CardsUsed[thisCard] != null)
                {
                    // If not null generate another random number and check again.
                    thisCard = yourCard.Next(66);
                }

                // Once null, grab the string value out of Cards array.
                pickedCard = Cards[thisCard];

                // Add element to CardsUsed array.
                CardsUsed[thisCard] = pickedCard;

                // Call the MovePlayer method.
                // MovePlayer(pickedCard); // Need to get player info from player class.
            }
            else
            {
                // Reset the CardsUsed array to null.
                for (int index1 = 0; index1 < CardsUsed.Length; index1++)
                {
                    CardsUsed[index1] = null;
                }

                // Draw a card.
                thisCard = yourCard.Next(66);

                // Grab the string value out of Cards array.
                pickedCard = Cards[thisCard];

                // Add element to CardsUsed array.
                CardsUsed[thisCard] = pickedCard;

                // Call the MovePlayer method.
                // MovePlayer(pickedCard); // Need to get player info from player class.
            }
            */
            MessageBox.Show(thisCard.ToString());
        }
    }
}
