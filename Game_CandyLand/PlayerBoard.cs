//-----------------------------------------------------------------------
// <copyright file="PlayerBoard.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Game_CandyLand
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Media;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Class for the PlayerBoard form.
    /// </summary>
    public partial class PlayerBoard : Form
    {
        /// <summary>
        /// Create a board for the players. 
        /// </summary> 
        private Deck cardDeck = new Deck();

        /// <summary>
        /// Create a deck.
        /// </summary> 
        private Board playBoard = new Board();

        /// <summary>
        /// Number of Players field.
        /// </summary>
        private int numberOfPlayers;

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
        /// Players piece as a label on the board form.
        /// </summary>
        private Label gamePiece;

        /// <summary>
        /// A List to hold the players in the current game.
        /// </summary>
        private List<Player> playerlist;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerBoard"/> class.
        /// </summary>
        public PlayerBoard()
        {
            this.InitializeComponent();
            lblLabel1.Parent = this.pbxGameBoard;
            lblLabel2.Parent = this.pbxGameBoard;
            lblLabel3.Parent = this.pbxGameBoard;
            lblLabel4.Parent = this.pbxGameBoard;
            this.lblOutputLog.Font = new Font("Arial", 14);
            this.lblMessages.Font = new Font("Arial", 14);
            this.lblLabel3.Visible = false;
            this.lblLabel2.Visible = false;
            this.lblLabel4.Visible = false;

            // Start background music.
            System.IO.Stream strBkgrnd = Properties.Resources.background;
            System.Media.SoundPlayer sndBkgrnd = new System.Media.SoundPlayer(strBkgrnd);
            sndBkgrnd.Play();
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
        public int NumberOfPlayers
        {
            get { return this.numberOfPlayers; }
            set { this.numberOfPlayers = value; }
        }

        /// <summary>
        /// Gets or sets this.gamePiece.
        /// </summary>
        public Label GamePiece
        {
            get { return this.gamePiece; }
            set { this.gamePiece = value; }
        }

        /// <summary>
        /// Gets or sets playerList.
        /// </summary>
        public List<Player> PlayerList
        {
            get { return this.playerlist; }
            set { this.playerlist = value; }
        }

        /// <summary>
        /// Gets or sets cardDeck field. 
        /// </summary> 
        public Deck CardDeck
        {
            get { return this.cardDeck; }
            set { this.cardDeck = value; }
        }

        /// <summary>
        /// Gets or sets playBoard.
        /// </summary> 
        public Board PlayBoard
        {
            get { return this.playBoard; }
            set { this.playBoard = value; }
        }

        /// <summary>
        /// Method to move players and get there current location.
        /// </summary>
        /// <param name="card">The card being passed to the MovePlayer method.</param>
        public void MovePlayer(string card)
        {
            System.IO.Stream strBkgrnd = Properties.Resources.background;
            System.Media.SoundPlayer sndBkgrnd = new System.Media.SoundPlayer(strBkgrnd);

            // todo this part needs to get changed for multiplayer
            int currentlocation = 0;

            // Set this.gamePiece to the correct label for locations
            // this.gamePiece = "lblLabel" + this.PlayerList[0].PlayerNumber;

            // Play move sound.
            System.IO.Stream strMove = Properties.Resources.move;
            System.Media.SoundPlayer sndMove = new System.Media.SoundPlayer(strMove);

            // If the player list is not null, set the game pieces.
            if (this.PlayerList != null)
            {
                // If current players player number is 1.
                if (this.PlayerList[0].PlayerNumber == 1 || this.PlayerList == null)
                {
                    // Set this.gamePiece = lblLabel1.
                    this.gamePiece = this.lblLabel1;
                }
                else if (this.PlayerList[0].PlayerNumber == 2)
                {
                    // Set this.gamePiece = lblLabel2.
                    this.gamePiece = this.lblLabel2;
                }
                else if (this.PlayerList[0].PlayerNumber == 3)
                {
                    // Set this.gamePiece = lblLabel3.
                    this.gamePiece = this.lblLabel3;
                }
                else
                {
                    // Current players player number is 4.
                    // Set this.gamePiece = lblLabel4.
                    this.gamePiece = this.lblLabel4;
                }
            }
            else
            {
                this.gamePiece = this.lblLabel1;
            }

            lblOutputLog.Refresh();
            lblMessages.Refresh();
            pbxCardDisplay.Refresh();

            // get players current location
            int i = 1;
            while (i < 135)
            {
                if (this.gamePiece.Location == new Point(this.PlayBoard.LocationsX[i], this.PlayBoard.LocationsY[i]))
                {
                    currentlocation = i;
                    break;
                }

                i++;
            }

            // Move player ahead if the player is on the Gumdrop pass bridge start square
            if (this.gamePiece.Location == new Point(this.playBoard.LocationsX[5], this.playBoard.LocationsY[5]))
            {
                // Rainbow Bridge beggins on location 5 and ends on location 59
                pbxGameBoard.Refresh();
                sndMove.Play();
                this.gamePiece.Location =
                    new Point(this.PlayBoard.LocationsX[59] - 5, this.PlayBoard.LocationsY[59] - 10);
                pbxGameBoard.Refresh();
                currentlocation = 59;
            }
            else if (this.gamePiece.Location == new Point(835, 648))
            {
                // Gumdrop bridge beggins on location 35 and ends on location 45
                pbxGameBoard.Refresh();
                sndMove.Play();
                this.gamePiece.Location =
                    new Point(this.playBoard.LocationsX[45] - 5, this.playBoard.LocationsY[45] - 10);
                pbxGameBoard.Refresh();
                currentlocation = 45;
            }

            int nextlocation = currentlocation + 1;
            while (nextlocation < 135)
            {
                pbxGameBoard.Refresh();
                sndMove.Play();
                if (this.PlayBoard.LocationsColor[nextlocation] == card)
                {
                    // TESTING ANIMATION
                    int nextSpace = currentlocation + 1;
                    while ((nextSpace - 1) != nextlocation)
                    {
                        pbxGameBoard.Refresh();
                        if (this.gamePiece.Location != new Point(
                                this.playBoard.LocationsX[nextSpace],
                                this.playBoard.LocationsY[nextSpace]))
                        {
                            this.gamePiece.Location = new Point(
                                this.PlayBoard.LocationsX[nextSpace],
                                this.PlayBoard.LocationsY[nextSpace]);
                            sndMove.Play();
                        }

                        pbxGameBoard.Refresh();

                        // Sleep for less time will make the movement faster(10-100ish), more time will make the movement slower(100+)
                        System.Threading.Thread.Sleep(150);
                        pbxGameBoard.Refresh();
                        nextSpace++;
                    }

                    lblMessages.Text += "\n" + "You went " + (nextlocation - currentlocation) + " spaces.";
                    if (nextlocation - currentlocation > 20)
                    {
                        lblMessages.Text += "\n WOW! Nice job!";
                    }

                    pbxGameBoard.Refresh();

                    // END TESTING
                    break;
                }
                else if (card == "Double Green")
                {
                    int firstlocation = nextlocation;
                    while (firstlocation < 135)
                    {
                        pbxGameBoard.Refresh();
                        if (this.PlayBoard.LocationsColor[firstlocation] == "Green")
                        {
                            // Double animation testing
                            int nextSpace = currentlocation + 1;
                            while ((nextSpace - 1) != firstlocation)
                            {
                                // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                pbxGameBoard.Refresh();
                                if (this.gamePiece.Location != new Point(
                                        this.playBoard.LocationsX[nextSpace],
                                        this.playBoard.LocationsY[nextSpace]))
                                {
                                    pbxGameBoard.Refresh();
                                    sndMove.Play();
                                    this.gamePiece.Location = new Point(
                                        this.PlayBoard.LocationsX[nextSpace],
                                        this.PlayBoard.LocationsY[nextSpace]);
                                    pbxGameBoard.Refresh();
                                }

                                pbxGameBoard.Refresh();
                                System.Threading.Thread.Sleep(150);
                                pbxGameBoard.Refresh();
                                nextSpace++;
                            }

                            // End testing.
                            // this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[firstlocation], this.PlayBoard.LocationsY[firstlocation]);
                            int doublelocation = firstlocation + 1;
                            while (doublelocation < 135)
                            {
                                pbxGameBoard.Refresh();
                                if (this.PlayBoard.LocationsColor[doublelocation] == "Green")
                                {
                                    // Double animation testing 2.
                                    nextSpace = firstlocation;
                                    while ((nextSpace - 1) != doublelocation)
                                    {
                                        // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                        pbxGameBoard.Refresh();
                                        if (this.gamePiece.Location != new Point(
                                                this.playBoard.LocationsX[nextSpace],
                                                this.playBoard.LocationsY[nextSpace]))
                                        {
                                            pbxGameBoard.Refresh();
                                            sndMove.Play();
                                            this.gamePiece.Location = new Point(
                                                this.PlayBoard.LocationsX[nextSpace],
                                                this.PlayBoard.LocationsY[nextSpace]);
                                            pbxGameBoard.Refresh();
                                        }

                                        pbxGameBoard.Refresh();
                                        System.Threading.Thread.Sleep(100);
                                        pbxGameBoard.Refresh();
                                        nextSpace++;
                                    }

                                    // end double animation testing for double green
                                    lblMessages.Text = "You went " + (doublelocation - currentlocation) + " spaces.";
                                    return;
                                }

                                doublelocation++;
                            }
                        }

                        firstlocation++;
                    }
                }
                else if (card == "Double Yellow")
                {
                    int firstlocation = nextlocation;
                    while (firstlocation < 135)
                    {
                        pbxGameBoard.Refresh();
                        if (this.PlayBoard.LocationsColor[firstlocation] == "Yellow")
                        {
                            // Double animation testing.
                            int nextSpace = currentlocation + 1;
                            while ((nextSpace - 1) != firstlocation)
                            {
                                // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                pbxGameBoard.Refresh();
                                if (this.gamePiece.Location != new Point(
                                        this.playBoard.LocationsX[nextSpace],
                                        this.playBoard.LocationsY[nextSpace]))
                                {
                                    pbxGameBoard.Refresh();
                                    sndMove.Play();
                                    this.gamePiece.Location = new Point(
                                        this.PlayBoard.LocationsX[nextSpace],
                                        this.PlayBoard.LocationsY[nextSpace]);
                                    pbxGameBoard.Refresh();
                                }

                                pbxGameBoard.Refresh();
                                System.Threading.Thread.Sleep(100);
                                pbxGameBoard.Refresh();
                                nextSpace++;
                            }

                            // End testing.
                            // this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[firstlocation], this.PlayBoard.LocationsY[firstlocation]);
                            int doublelocation = firstlocation + 1;
                            while (doublelocation < 135)
                            {
                                pbxGameBoard.Refresh();
                                if (this.PlayBoard.LocationsColor[doublelocation] == "Yellow")
                                {
                                    // Double animation testing 2
                                    nextSpace = firstlocation;
                                    while ((nextSpace - 1) != doublelocation)
                                    {
                                        // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                        pbxGameBoard.Refresh();
                                        if (this.gamePiece.Location != new Point(
                                                this.playBoard.LocationsX[nextSpace],
                                                this.playBoard.LocationsY[nextSpace]))
                                        {
                                            pbxGameBoard.Refresh();
                                            sndMove.Play();
                                            this.gamePiece.Location = new Point(
                                                this.PlayBoard.LocationsX[nextSpace],
                                                this.PlayBoard.LocationsY[nextSpace]);
                                            pbxGameBoard.Refresh();
                                        }

                                        pbxGameBoard.Refresh();
                                        System.Threading.Thread.Sleep(100);
                                        pbxGameBoard.Refresh();
                                        nextSpace++;
                                    }

                                    // End double animation testing for double green.
                                    lblMessages.Text = "You went " + (doublelocation - currentlocation) + " spaces.";
                                    return;
                                }

                                doublelocation++;
                            }
                        }

                        firstlocation++;
                    }
                }
                else if (card == "Double Red")
                {
                    int firstlocation = nextlocation;
                    while (firstlocation < 135)
                    {
                        pbxGameBoard.Refresh();
                        if (this.PlayBoard.LocationsColor[firstlocation] == "Red")
                        {
                            // Double animation testing
                            int nextSpace = currentlocation + 1;
                            while ((nextSpace - 1) != firstlocation)
                            {
                                // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                pbxGameBoard.Refresh();
                                if (this.gamePiece.Location != new Point(
                                        this.playBoard.LocationsX[nextSpace],
                                        this.playBoard.LocationsY[nextSpace]))
                                {
                                    pbxGameBoard.Refresh();
                                    sndMove.Play();
                                    this.gamePiece.Location = new Point(
                                        this.PlayBoard.LocationsX[nextSpace],
                                        this.PlayBoard.LocationsY[nextSpace]);
                                    pbxGameBoard.Refresh();
                                }

                                pbxGameBoard.Refresh();
                                System.Threading.Thread.Sleep(100);
                                pbxGameBoard.Refresh();
                                nextSpace++;
                            }

                            // end testing.
                            // this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[firstlocation], this.PlayBoard.LocationsY[firstlocation]);
                            int doublelocation = firstlocation + 1;
                            while (doublelocation < 135)
                            {
                                pbxGameBoard.Refresh();
                                if (this.PlayBoard.LocationsColor[doublelocation] == "Red")
                                {
                                    // Double animation testing 2.
                                    nextSpace = firstlocation;
                                    while ((nextSpace - 1) != doublelocation)
                                    {
                                        // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                        pbxGameBoard.Refresh();
                                        if (this.gamePiece.Location != new Point(
                                                this.playBoard.LocationsX[nextSpace],
                                                this.playBoard.LocationsY[nextSpace]))
                                        {
                                            pbxGameBoard.Refresh();
                                            sndMove.Play();
                                                this.gamePiece.Location = new Point(
                                                    this.PlayBoard.LocationsX[nextSpace],
                                                    this.PlayBoard.LocationsY[nextSpace]);
                                            pbxGameBoard.Refresh();
                                        }

                                        pbxGameBoard.Refresh();
                                        System.Threading.Thread.Sleep(100);
                                        pbxGameBoard.Refresh();
                                        nextSpace++;
                                    }

                                    // End double animation testing for double green.
                                    lblMessages.Text = "You went " + (doublelocation - currentlocation) + " spaces.";
                                    return;
                                }

                                doublelocation++;
                                pbxGameBoard.Refresh();
                            }
                        }

                        pbxGameBoard.Refresh();
                        firstlocation++;
                    }
                }
                else if (card == "Double Purple")
                {
                    int firstlocation = nextlocation;
                    while (firstlocation < 135)
                    {
                        pbxGameBoard.Refresh();
                        if (this.PlayBoard.LocationsColor[firstlocation] == "Purple")
                        {
                            // Double animation testing
                            int nextSpace = currentlocation + 1;
                            while ((nextSpace - 1) != firstlocation)
                            {
                                // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                pbxGameBoard.Refresh();
                                if (this.gamePiece.Location != new Point(
                                    this.playBoard.LocationsX[nextSpace],
                                        this.playBoard.LocationsY[nextSpace]))
                                {
                                    pbxGameBoard.Refresh();
                                    sndMove.Play();
                                    this.gamePiece.Location = new Point(
                                        this.PlayBoard.LocationsX[nextSpace],
                                        this.PlayBoard.LocationsY[nextSpace]);
                                    pbxGameBoard.Refresh();
                                }

                                pbxGameBoard.Refresh();
                                System.Threading.Thread.Sleep(100);
                                pbxGameBoard.Refresh();
                                nextSpace++;
                            }

                            // End testing
                            // this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[firstlocation], this.PlayBoard.LocationsY[firstlocation]);
                            int doublelocation = firstlocation + 1;
                            while (doublelocation < 135)
                            {
                                pbxGameBoard.Refresh();
                                if (this.PlayBoard.LocationsColor[doublelocation] == "Purple")
                                {
                                    // Double animation testing 2.
                                    nextSpace = firstlocation;
                                    while ((nextSpace - 1) != doublelocation)
                                    {
                                        // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                        pbxGameBoard.Refresh();
                                        if (this.gamePiece.Location != new Point(
                                                this.playBoard.LocationsX[nextSpace],
                                                this.playBoard.LocationsY[nextSpace]))
                                        {
                                            pbxGameBoard.Refresh();
                                            sndMove.Play();
                                            this.gamePiece.Location = new Point(
                                                this.PlayBoard.LocationsX[nextSpace],
                                                this.PlayBoard.LocationsY[nextSpace]);
                                            pbxGameBoard.Refresh();
                                        }

                                        pbxGameBoard.Refresh();
                                        System.Threading.Thread.Sleep(100);
                                        pbxGameBoard.Refresh();
                                        nextSpace++;
                                    }

                                    // End double animation testing for double green
                                    lblMessages.Text = "You went " + (doublelocation - currentlocation) + " spaces.";
                                    return;
                                }

                                doublelocation++;
                            }
                        }

                        pbxGameBoard.Refresh();
                        firstlocation++;
                    }
                }
                else if (card == "Double Blue")
                {
                    int firstlocation = nextlocation;
                    while (firstlocation < 135)
                    {
                        pbxGameBoard.Refresh();
                        if (this.PlayBoard.LocationsColor[firstlocation] == "Blue")
                        {
                            // Double animation testing.
                            int nextSpace = currentlocation + 1;
                            while ((nextSpace - 1) != firstlocation)
                            {
                                // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                pbxGameBoard.Refresh();
                                if (this.gamePiece.Location != new Point(
                                        this.playBoard.LocationsX[nextSpace],
                                        this.playBoard.LocationsY[nextSpace]))
                                {
                                    pbxGameBoard.Refresh();
                                    sndMove.Play();
                                    this.gamePiece.Location = new Point(
                                        this.PlayBoard.LocationsX[nextSpace],
                                        this.PlayBoard.LocationsY[nextSpace]);
                                    pbxGameBoard.Refresh();
                                }

                                pbxGameBoard.Refresh();
                                System.Threading.Thread.Sleep(100);
                                pbxGameBoard.Refresh();
                                nextSpace++;
                            }

                            // End testing.
                            // this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[firstlocation], this.PlayBoard.LocationsY[firstlocation]);
                            int doublelocation = firstlocation + 1;
                            while (doublelocation < 135)
                            {
                                pbxGameBoard.Refresh();
                                if (this.PlayBoard.LocationsColor[doublelocation] == "Blue")
                                {
                                    // Double animation testing 2.
                                    nextSpace = firstlocation;
                                    while ((nextSpace - 1) != doublelocation)
                                    {
                                        // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                        pbxGameBoard.Refresh();
                                        if (this.gamePiece.Location != new Point(
                                                this.playBoard.LocationsX[nextSpace],
                                                this.playBoard.LocationsY[nextSpace]))
                                        {
                                            pbxGameBoard.Refresh();
                                            sndMove.Play();
                                            this.gamePiece.Location = new Point(
                                                this.PlayBoard.LocationsX[nextSpace],
                                                this.PlayBoard.LocationsY[nextSpace]);
                                            pbxGameBoard.Refresh();
                                        }

                                        pbxGameBoard.Refresh();
                                        System.Threading.Thread.Sleep(100);
                                        pbxGameBoard.Refresh();
                                        nextSpace++;
                                    }

                                    // End double animation testing for double green.
                                    lblMessages.Text = "You went " + (doublelocation - currentlocation) + " spaces.";
                                    return;
                                }

                                pbxGameBoard.Refresh();
                                doublelocation++;
                            }
                        }

                        pbxGameBoard.Refresh();
                        firstlocation++;
                    }
                }
                else if (card == "Double Orange")
                {
                    int firstlocation = nextlocation;
                    while (firstlocation < 135)
                    {
                        pbxGameBoard.Refresh();
                        if (this.PlayBoard.LocationsColor[firstlocation] == "Orange")
                        {
                            // Double animation testing.
                            int nextSpace = currentlocation + 1;
                            while ((nextSpace - 1) != firstlocation)
                            {
                                // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                pbxGameBoard.Refresh();
                                if (this.gamePiece.Location != new Point(
                                        this.playBoard.LocationsX[nextSpace],
                                        this.playBoard.LocationsY[nextSpace]))
                                {
                                    pbxGameBoard.Refresh();
                                    sndMove.Play();
                                    this.gamePiece.Location = new Point(
                                        this.PlayBoard.LocationsX[nextSpace],
                                        this.PlayBoard.LocationsY[nextSpace]);
                                    pbxGameBoard.Refresh();
                                }

                                pbxGameBoard.Refresh();
                                System.Threading.Thread.Sleep(200);
                                pbxGameBoard.Refresh();
                                nextSpace++;
                            }

                            // End testing.
                            // this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[firstlocation], this.PlayBoard.LocationsY[firstlocation]);
                            int doublelocation = firstlocation + 1;
                            while (doublelocation < 135)
                            {
                                pbxGameBoard.Refresh();
                                if (this.PlayBoard.LocationsColor[doublelocation] == "Orange")
                                {
                                    // Double animation testing 2.
                                    nextSpace = firstlocation;
                                    while ((nextSpace - 1) != doublelocation)
                                    {
                                        // MessageBox.Show(nextSpace.ToString(), nextlocation.ToString());
                                        pbxGameBoard.Refresh();
                                        if (this.gamePiece.Location != new Point(
                                                this.playBoard.LocationsX[nextSpace],
                                                this.playBoard.LocationsY[nextSpace]))
                                        {
                                            pbxGameBoard.Refresh();
                                            sndMove.Play();
                                            this.gamePiece.Location = new Point(
                                                this.PlayBoard.LocationsX[nextSpace],
                                                this.PlayBoard.LocationsY[nextSpace]);
                                            pbxGameBoard.Refresh();
                                        }

                                        pbxGameBoard.Refresh();
                                        System.Threading.Thread.Sleep(100);
                                        pbxGameBoard.Refresh();
                                        nextSpace++;
                                    }

                                    lblMessages.Text = "You went " + (doublelocation - currentlocation) + " spaces.";

                                    // End double animation testing for double green.
                                    return;
                                }

                                pbxGameBoard.Refresh();
                                doublelocation++;
                            }
                        }

                        pbxGameBoard.Refresh();
                        firstlocation++;
                    }
                }

                nextlocation++;

                // When player is on the second to last square they can then win the game on their next card draw.
                if (this.gamePiece.Location == new Point(this.playBoard.LocationsX[133], this.playBoard.LocationsY[133]))
                {
                    // Places player on the finishing square.
                    this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[134], this.PlayBoard.LocationsY[134]);

                    // Disable draw button once a player wins.
                    this.btnDraw.Enabled = false;
                    
                    // Close current player board.
                    this.Hide();

                    // Message box to display winner.
                    WinScreen winner = new WinScreen();

                    // checks to see who was on the last square.
                    if (lblLabel1.Location == new Point(this.PlayBoard.LocationsX[134], this.PlayBoard.LocationsY[134]))
                    {
                        // If player 1 wins display text.
                        winner.LblWin.Text = "Congratulations player 1 wins!";

                        // Change font color to color of player piece.
                        winner.LblWin.ForeColor = Color.Blue;
                    }
                    else if (lblLabel2.Location ==
                             new Point(this.PlayBoard.LocationsX[134], this.PlayBoard.LocationsY[134]))
                    {
                        // If player 2 wins display text.
                        winner.LblWin.Text = "Congratulations player 2 wins!";

                        // Change font color to color of player piece.
                        winner.LblWin.ForeColor = Color.Green;
                    }
                    else if (lblLabel3.Location ==
                             new Point(this.PlayBoard.LocationsX[134], this.PlayBoard.LocationsY[134]))
                    {
                        // If player 3 wins display text.
                        winner.LblWin.Text = "Congratulations player 3 wins!";

                        // Change font color to color of player piece.
                        winner.LblWin.ForeColor = Color.Yellow;
                    }
                    else if (lblLabel4.Location ==
                             new Point(this.PlayBoard.LocationsX[134], this.PlayBoard.LocationsY[134]))
                    {
                        // If player 4 wins display text.
                        winner.LblWin.Text = "Congratulations player 4 wins!";

                        // Change font color to color of player piece.
                        winner.LblWin.ForeColor = Color.Red;
                    }

                    // Show the form for the winner.
                    winner.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Method to create a playlist.
        /// </summary>
        /// <param name="numPlayers">The number of players.</param>
        public void CreatePlayerList(int numPlayers)
        {
            // Make a list to hold the players.
            this.PlayerList = new List<Player>();

            if (this.numberOfPlayers == 2)
            {
                // Create an instance of a player.
                Player playerOne = new Player()
                {
                    // Set the fields of playerOne.
                    PlayerNumber = 1,
                };

                // Add the player to the playerList.
                this.PlayerList.Add(playerOne);

                // Create an instance of a player.
                Player playerTwo = new Player()
                {
                    // Set the fields of playerTwo.
                    PlayerNumber = 2,
                };

                this.lblLabel2.Visible = true;

                // Add the player to the playerList.
                this.PlayerList.Add(playerTwo);
            }
            else if (this.numberOfPlayers == 3)
            {
                // Number of players is three.
                // Create an instance of a player.
                Player playerOne = new Player()
                {
                    // Set the fields of playerOne.
                    PlayerNumber = 1
                };

                // Add the player to the playerList.
                this.PlayerList.Add(playerOne);

                // Create an instance of a player.
                Player playerTwo = new Player()
                {
                    // Set the fields of playerTwo.
                    PlayerNumber = 2,
                };
                this.lblLabel2.Visible = true;

                // Add the player to the playerList.
                this.PlayerList.Add(playerTwo);

                // Create an instance of a player.
                Player playerThree = new Player()
                {
                    // Set the fields of playerThree.
                    PlayerNumber = 3,
                };
                this.lblLabel3.Visible = true;

                // Add the player to the playerList.
                this.PlayerList.Add(playerThree);
            }
            else
            {
                // Number of players is four.
                // Create an instance of a player.
                Player playerOne = new Player()
                {
                    // Set the fields of playerOne.
                    PlayerNumber = 1,
                };

                // Add the player to the playerList.
                this.PlayerList.Add(playerOne);

                // Create an instance of a player.
                Player playerTwo = new Player()
                {
                    // Set the fields of playerTwo.
                    PlayerNumber = 2,
                };

                this.lblLabel2.Visible = true;

                // Add the player to the playerList.
                this.PlayerList.Add(playerTwo);

                // Create an instance of a player.
                Player playerThree = new Player()
                {
                    // Set the fields of playerThree.
                    PlayerNumber = 3,
                };

                this.lblLabel3.Visible = true;

                // Add the player to the playerList.
                this.PlayerList.Add(playerThree);

                // Create an instance of a player.
                Player playerFour = new Player()
                {
                    // Set the fields of playerFour.
                    PlayerNumber = 4,
                };

                this.lblLabel4.Visible = true;

                // Add the player to the playerList.
                this.PlayerList.Add(playerFour);
            }
        }

        /// <summary>
        /// Method to check which players turn it is. 
        /// </summary>
        public void CurrentPlayerTurn()
        {
            // Prepare the draw card sound.
            System.IO.Stream strDraw = Properties.Resources.draw;
            System.Media.SoundPlayer sndDraw = new System.Media.SoundPlayer(strDraw);

            // Prepare the fail sound.
            System.IO.Stream strFail = Properties.Resources.fail;
            System.Media.SoundPlayer sndFail = new System.Media.SoundPlayer(strFail);

            // If player list is not empty.
            if (this.PlayerList != null)
            {
                // Set current player equal to the player lists 0th elements player number.
                this.currentPlayer = this.PlayerList[0].PlayerNumber;

                // Message box to show the current players turn.
                // MessageBox.Show("It is player " + this.currentPlayer + "'s turn.");
                lblPlayerTurn.Text = "It is player " + this.currentPlayer + "'s turn.";
                lblPlayerTurn.Refresh();
                //// Check stuck value for current player
                if (this.PlayerList[0].Stuck != true)
                {
                    // Check if current player is a computer.
                    if (this.PlayerList[0].IsComputer)
                    {
                        System.IO.Stream strBkgrnd = Properties.Resources.background;
                        System.Media.SoundPlayer sndBkgrnd = new System.Media.SoundPlayer(strBkgrnd);
                        sndBkgrnd.Play();

                        // if it is disable the draw button.
                        this.btnDraw.Enabled = false;

                        // Instantiate a random number generator.
                        Random random = new Random();

                        // Refresh labels.
                        lblMessages.Refresh();
                        lblOutputLog.Refresh();

                        // Delay a few seconds for computer to go.
                        System.Threading.Thread.Sleep(random.Next(750, 2000));
                        lblMessages.Refresh();
                        lblOutputLog.Refresh();

                        // Call the draw card click event.
                        this.BtnDraw_Click(null, null);
                        sndDraw.Play();
                        System.Threading.Thread.Sleep(200);                      
                        sndBkgrnd.Play();
                        this.BtnNextPlayer_Click(null, null);
                        return;
                    }
                    else
                    {
                        // enable the draw button.
                        this.btnDraw.Enabled = true;

                        // Message box telling the current player to draw a card.
                        MessageBox.Show("Player " + this.currentPlayer + " please draw a card.");
                    }
                }
                else
                {
                    // If current player is a person the user must the hit button to go to the next player.
                    if (this.PlayerList[0].IsComputer == false)
                    {
                        // Display error message.
                        sndFail.Play();
                        MessageBox.Show("Awww you're stuck for this turn! Hit the next player button.");
                    }
                    else
                    {
                        System.IO.Stream strBkgrnd = Properties.Resources.background;
                        System.Media.SoundPlayer sndBkgrnd = new System.Media.SoundPlayer(strBkgrnd);
                        sndBkgrnd.Play();
                        //// Player is a computer and should call the next player click event.
                        this.BtnNextPlayer_Click(null, null);
                    }
                }
            }
        }

        /// <summary>
        /// Method to start the game
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnDraw_Click(object sender, EventArgs e)
        {
            // Make sure the draw button says draw
            this.btnDraw.Text = "Draw";

            // If the player list is not null, set the game pieces.
            if (this.PlayerList != null)
            {
                // If current players player number is 1.
                if (this.PlayerList[0].PlayerNumber == 1 || this.PlayerList == null)
                {
                    // Set this.gamePiece = lblLabel1.
                    this.gamePiece = this.lblLabel1;
                }
                else if (this.PlayerList[0].PlayerNumber == 2)
                {
                    // Set this.gamePiece = lblLabel2.
                    this.gamePiece = this.lblLabel2;
                }
                else if (this.PlayerList[0].PlayerNumber == 3)
                {
                    // Set this.gamePiece = lblLabel3.
                    this.gamePiece = this.lblLabel3;
                }
                else
                {
                    // Current players player number is 4.
                    // Set this.gamePiece = lblLabel4.
                    this.gamePiece = this.lblLabel4;
                }
            }
            else
            {
                this.gamePiece = this.lblLabel1;
            }

            // Prepare the variables for use.
            lblMessages.Text = string.Empty;
            lblOutputLog.Text = string.Empty;
            int currentlocation = 0;

            // Play the draw card sound.
            System.IO.Stream strDraw = Properties.Resources.draw;
            System.Media.SoundPlayer sndDraw = new System.Media.SoundPlayer(strDraw);
            sndDraw.Play();

            // Play the draw card sound.
            System.IO.Stream strFail = Properties.Resources.fail;
            System.Media.SoundPlayer sndFail = new System.Media.SoundPlayer(strFail);

            // get players current location
            int i = 1;
            while (i < 135)
            {
                if (this.gamePiece.Location == new Point(this.PlayBoard.LocationsX[i], this.PlayBoard.LocationsY[i]))
                {
                    currentlocation = i;
                    break;
                }

                i++;
            }

            string currentCard = this.CardDeck.Draw();
            lblMessages.Text = "You got a " + currentCard.ToString() + " card.";
            lblMessages.Refresh();
            lblMessages.ForeColor = System.Drawing.Color.Magenta;
            this.lblOutputLog.Text = currentCard;
            lblOutputLog.Refresh();

            // Display Card in picture box from corresponding element of image list.
            if (this.CardDeck.CurrentCard == "Green")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[0];
            }
            else if (this.CardDeck.CurrentCard == "Double Green")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[1];
            }
            else if (this.CardDeck.CurrentCard == "Red")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[2];
            }
            else if (this.CardDeck.CurrentCard == "Double Red")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[3];
            }
            else if (this.CardDeck.CurrentCard == "Orange")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[4];
            }
            else if (this.CardDeck.CurrentCard == "Double Orange")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[5];
            }
            else if (this.CardDeck.CurrentCard == "Blue")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[6];
            }
            else if (this.CardDeck.CurrentCard == "Double Blue")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[7];
            }
            else if (this.CardDeck.CurrentCard == "Purple")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[8];
            }
            else if (this.CardDeck.CurrentCard == "Double Purple")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[9];
            }
            else if (this.CardDeck.CurrentCard == "Yellow")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[10];
            }
            else if (this.CardDeck.CurrentCard == "Double Yellow")
            {
                this.pbxCardDisplay.Image = this.imgListCards.Images[11];
            }
            else if (this.CardDeck.CurrentCard == "Candy Cane")
            {
                if (currentlocation > 20)
                {
                    int back = currentlocation - 20;
                    this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[20], this.PlayBoard.LocationsY[20]);
                    lblMessages.ForeColor = System.Drawing.Color.Red;
                    sndFail.Play();
                    lblMessages.Text = "Yikes you went back " + back + " spaces.";
                }

                this.pbxCardDisplay.Image = this.imgListCards.Images[12];
            }
            else if (this.CardDeck.CurrentCard == "Peanut Brittle")
            {
                if (currentlocation > 69)
                {
                    int back = currentlocation - 69;
                    this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[69], this.PlayBoard.LocationsY[69]);
                    lblMessages.ForeColor = System.Drawing.Color.Red;
                    sndFail.Play();
                    lblMessages.Text = "Yikes you went back " + back + " spaces.";
                }

                this.pbxCardDisplay.Image = this.imgListCards.Images[13];
            }
            else if (this.CardDeck.CurrentCard == "Lolly")
            {
                if (currentlocation > 69)
                {
                    int back = currentlocation - 69;
                    this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[92], this.PlayBoard.LocationsY[92]);
                    lblMessages.ForeColor = System.Drawing.Color.Red;
                    sndFail.Play();
                    lblMessages.Text = "Yikes you went back " + back + " spaces.";
                }

                this.pbxCardDisplay.Image = this.imgListCards.Images[14];
            }
            else if (this.CardDeck.CurrentCard == "Princess Frostine")
            {
                if (currentlocation > 102)
                {
                    int back = currentlocation - 102;
                    this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[102], this.PlayBoard.LocationsY[102]);
                    lblMessages.ForeColor = System.Drawing.Color.Red;
                    sndFail.Play();
                    lblMessages.Text = "Yikes you went back " + back + " spaces.";
                }

                this.pbxCardDisplay.Image = this.imgListCards.Images[15];
            }
            else if (this.CardDeck.CurrentCard == "Gumdrop")
            {
                if (currentlocation > 42)
                {
                    int back = currentlocation - 42;
                    this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[42], this.PlayBoard.LocationsY[42]);
                    lblMessages.ForeColor = System.Drawing.Color.Red;
                    sndFail.Play();
                    lblMessages.Text = "Yikes you went back " + back + "spaces.";
                }

                this.pbxCardDisplay.Image = this.imgListCards.Images[16];
            }
            else if (this.CardDeck.CurrentCard == "GingerbreadMan")
            {
                if (currentlocation > 9)
                {
                    int back = currentlocation - 9;
                    this.gamePiece.Location = new Point(this.PlayBoard.LocationsX[9], this.PlayBoard.LocationsY[9]);
                    lblMessages.ForeColor = System.Drawing.Color.Red;
                    sndFail.Play();
                    lblMessages.Text = "Yikes you went back " + back + " spaces.";
                }

                this.pbxCardDisplay.Image = this.imgListCards.Images[17];
            }

            this.MovePlayer(currentCard);

            this.CheckPlayers();
            this.btnDraw.Enabled = false;

            // Set turn done to true.
            // this.PlayerList[0].TurnDone = true;
            if (this.PlayerList != null)
            {
                // Call Set Round method if current player is player 1.
                if (this.PlayerList[0].PlayerNumber == this.PlayerList.Count)
                {
                    // Call SetRound.
                    this.SetRound();
                }
                else
                {
                    // Round is still going.
                }
            }
            else
            {
                // Call set round method every time player goes.
                this.SetRound();
            }

            if (this.PlayerList != null)
            {
                if (this.PlayerList[0].PlayerNumber == 1 && this.round == 1)
                {
                    this.BtnNextPlayer_Click(null, null);
                }
            }
        }

        /// <summary>
        /// Method for while the board is loading.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void PlayerBoard_Load(object sender, EventArgs e)
        {
            // Hide form and hide excess players.
            if (this.numberOfPlayers == 2)
            {
                // Hide the excess players.
                lblLabel3.Hide();
                lblLabel4.Hide();
            }
            else if (this.numberOfPlayers == 3)
            {
                // Hide the excess players.
                lblLabel4.Hide();
            }
            else
            {
                // All players are being used and none of the pieces need to be hidden.
            }

            // Set round equal to 0.
            this.round = 1;

            // Set round label to round 1.
            lblRound.Text = "Round 1";

            // btnDraw enable.
            this.btnDraw.Enabled = true;

            // set up locations for where each color is on the board
            int[] greenLocations = new int[21]
            {
                6, 13, 19, 26, 32, 38, 45, 51, 57, 63, 70, 76, 82, 88, 95, 101, 108, 114, 120, 126, 132
            };

            int[] orangeLocations = new int[21]
            {
                5, 12, 18, 25, 31, 37, 44, 50, 56, 62, 68, 75, 81, 87, 94, 100, 107, 113, 119, 125, 131
            };

            int[] blueLocations = new int[21]
            {
                4, 11, 17, 24, 30, 36, 43, 49, 55, 61, 67, 74, 80, 86, 93, 99, 106, 112, 118, 124, 130
            };

            int[] yellowLocations = new int[21]
            {
                3, 10, 16, 23, 29, 35, 41, 48, 54, 60, 66, 73, 79, 85, 91, 98, 105, 111, 117, 123, 129
            };

            int[] purpleLocations = new int[21]
            {
                2, 8, 15, 22, 28, 34, 40, 47, 53, 59, 65, 72, 78, 84, 90, 97, 104, 110, 116, 122, 128
            };

            int[] redLocations = new int[22]
            {
                1, 7, 14, 21, 27, 33, 39, 46, 52, 58, 64, 71, 77, 83, 89, 96, 103, 109, 115, 121, 127, 133
            };

            int[] specialLocations = new int[6] { 9, 20, 42, 69, 92, 102 };

            // set up 134 board locations in the locations array
            for (int i = 0; i < this.PlayBoard.Locations.Length; i++)
            {
                this.PlayBoard.Locations[i] = i;
            }

            // set up the x and y locations for each location by adding it to the correct array LONG
            // Any way to improve below code?
            this.PlayBoard.LocationsX[0] = 0;
            this.PlayBoard.LocationsY[0] = 0;

            this.PlayBoard.LocationsX[1] = 211;
            this.PlayBoard.LocationsY[1] = 814;

            this.PlayBoard.LocationsX[2] = 259;
            this.PlayBoard.LocationsY[2] = 813;

            this.PlayBoard.LocationsX[3] = 297;
            this.PlayBoard.LocationsY[3] = 800;

            this.PlayBoard.LocationsX[4] = 321;
            this.PlayBoard.LocationsY[4] = 770;

            this.PlayBoard.LocationsX[5] = 340;
            this.PlayBoard.LocationsY[5] = 733;

            this.PlayBoard.LocationsX[6] = 372;
            this.PlayBoard.LocationsY[6] = 702;

            this.PlayBoard.LocationsX[7] = 416;
            this.PlayBoard.LocationsY[7] = 686;

            this.PlayBoard.LocationsX[8] = 459;
            this.PlayBoard.LocationsY[8] = 684;

            // Gingerbread Man.
            this.PlayBoard.LocationsX[9] = 509;
            this.PlayBoard.LocationsY[9] = 689;

            this.PlayBoard.LocationsX[10] = 549;
            this.PlayBoard.LocationsY[10] = 704;

            this.PlayBoard.LocationsX[11] = 585;
            this.PlayBoard.LocationsY[11] = 733;

            this.PlayBoard.LocationsX[12] = 613;
            this.PlayBoard.LocationsY[12] = 767;

            this.PlayBoard.LocationsX[13] = 647;
            this.PlayBoard.LocationsY[13] = 792;

            this.PlayBoard.LocationsX[14] = 685;
            this.PlayBoard.LocationsY[14] = 820;

            this.PlayBoard.LocationsX[15] = 729;
            this.PlayBoard.LocationsY[15] = 830;

            this.PlayBoard.LocationsX[16] = 772;
            this.PlayBoard.LocationsY[16] = 835;

            this.PlayBoard.LocationsX[17] = 817;
            this.PlayBoard.LocationsY[17] = 834;

            this.PlayBoard.LocationsX[18] = 864;
            this.PlayBoard.LocationsY[18] = 830;

            this.PlayBoard.LocationsX[19] = 901;
            this.PlayBoard.LocationsY[19] = 811;

            this.PlayBoard.LocationsX[20] = 916;
            this.PlayBoard.LocationsY[20] = 767;

            this.PlayBoard.LocationsX[21] = 893;
            this.PlayBoard.LocationsY[21] = 732;

            this.PlayBoard.LocationsX[22] = 853;
            this.PlayBoard.LocationsY[22] = 713;

            this.PlayBoard.LocationsX[23] = 806;
            this.PlayBoard.LocationsY[23] = 713;

            this.PlayBoard.LocationsX[24] = 761;
            this.PlayBoard.LocationsY[24] = 713;

            this.PlayBoard.LocationsX[25] = 714;
            this.PlayBoard.LocationsY[25] = 713;

            this.PlayBoard.LocationsX[26] = 668;
            this.PlayBoard.LocationsY[26] = 713;

            this.PlayBoard.LocationsX[27] = 628;
            this.PlayBoard.LocationsY[27] = 694;

            this.PlayBoard.LocationsX[28] = 599;
            this.PlayBoard.LocationsY[28] = 659;

            this.PlayBoard.LocationsX[29] = 594;
            this.PlayBoard.LocationsY[29] = 613;

            this.PlayBoard.LocationsX[30] = 626;
            this.PlayBoard.LocationsY[30] = 584;

            this.PlayBoard.LocationsX[31] = 673;
            this.PlayBoard.LocationsY[31] = 582;

            this.PlayBoard.LocationsX[32] = 717;
            this.PlayBoard.LocationsY[32] = 596;

            this.PlayBoard.LocationsX[33] = 759;
            this.PlayBoard.LocationsY[33] = 622;

            this.PlayBoard.LocationsX[34] = 800;
            this.PlayBoard.LocationsY[34] = 643;

            this.PlayBoard.LocationsX[35] = 840;
            this.PlayBoard.LocationsY[35] = 658;

            this.PlayBoard.LocationsX[36] = 883;
            this.PlayBoard.LocationsY[36] = 670;

            this.PlayBoard.LocationsX[37] = 930;
            this.PlayBoard.LocationsY[37] = 668;

            this.PlayBoard.LocationsX[38] = 969;
            this.PlayBoard.LocationsY[38] = 646;

            this.PlayBoard.LocationsX[39] = 992;
            this.PlayBoard.LocationsY[39] = 611;

            this.PlayBoard.LocationsX[40] = 995;
            this.PlayBoard.LocationsY[40] = 564;

            this.PlayBoard.LocationsX[41] = 979;
            this.PlayBoard.LocationsY[41] = 524;

            // SPECIAL 
            this.PlayBoard.LocationsX[42] = 941;
            this.PlayBoard.LocationsY[42] = 499;

            this.PlayBoard.LocationsX[43] = 891;
            this.PlayBoard.LocationsY[43] = 503;

            this.PlayBoard.LocationsX[44] = 850;
            this.PlayBoard.LocationsY[44] = 516;

            // RECIEVES FROM 35
            this.PlayBoard.LocationsX[45] = 806;
            this.PlayBoard.LocationsY[45] = 532;

            // STUCK
            this.PlayBoard.LocationsX[46] = 760;
            this.PlayBoard.LocationsY[46] = 527;

            this.PlayBoard.LocationsX[47] = 718;
            this.PlayBoard.LocationsY[47] = 508;

            this.PlayBoard.LocationsX[48] = 681;
            this.PlayBoard.LocationsY[48] = 484;

            this.PlayBoard.LocationsX[49] = 640;
            this.PlayBoard.LocationsY[49] = 457;

            this.PlayBoard.LocationsX[50] = 598;
            this.PlayBoard.LocationsY[50] = 442;

            this.PlayBoard.LocationsX[51] = 552;
            this.PlayBoard.LocationsY[51] = 435;

            this.PlayBoard.LocationsX[52] = 504;
            this.PlayBoard.LocationsY[52] = 441;

            this.PlayBoard.LocationsX[53] = 462;
            this.PlayBoard.LocationsY[53] = 456;

            this.PlayBoard.LocationsX[54] = 422;
            this.PlayBoard.LocationsY[54] = 481;

            this.PlayBoard.LocationsX[55] = 392;
            this.PlayBoard.LocationsY[55] = 514;

            this.PlayBoard.LocationsX[56] = 362;
            this.PlayBoard.LocationsY[56] = 550;

            this.PlayBoard.LocationsX[57] = 335;
            this.PlayBoard.LocationsY[57] = 587;

            this.PlayBoard.LocationsX[58] = 305;
            this.PlayBoard.LocationsY[58] = 617;

            // RECIEVE FROM 5
            this.PlayBoard.LocationsX[59] = 268;
            this.PlayBoard.LocationsY[59] = 642;

            this.PlayBoard.LocationsX[60] = 228;
            this.PlayBoard.LocationsY[60] = 653;

            this.PlayBoard.LocationsX[61] = 186;
            this.PlayBoard.LocationsY[61] = 656;

            this.PlayBoard.LocationsX[62] = 142;
            this.PlayBoard.LocationsY[62] = 648;

            this.PlayBoard.LocationsX[63] = 102;
            this.PlayBoard.LocationsY[63] = 636;

            this.PlayBoard.LocationsX[64] = 67;
            this.PlayBoard.LocationsY[64] = 609;

            this.PlayBoard.LocationsX[65] = 51;
            this.PlayBoard.LocationsY[65] = 569;

            this.PlayBoard.LocationsX[66] = 44;
            this.PlayBoard.LocationsY[66] = 522;

            this.PlayBoard.LocationsX[67] = 69;
            this.PlayBoard.LocationsY[67] = 488;

            this.PlayBoard.LocationsX[68] = 109;
            this.PlayBoard.LocationsY[68] = 473;

            // Peanut Brittle
            this.PlayBoard.LocationsX[69] = 152;
            this.PlayBoard.LocationsY[69] = 476;

            this.PlayBoard.LocationsX[70] = 192;
            this.PlayBoard.LocationsY[70] = 489;

            this.PlayBoard.LocationsX[71] = 235;
            this.PlayBoard.LocationsY[71] = 504;

            this.PlayBoard.LocationsX[72] = 281;
            this.PlayBoard.LocationsY[72] = 508;

            this.PlayBoard.LocationsX[73] = 319;
            this.PlayBoard.LocationsY[73] = 494;

            this.PlayBoard.LocationsX[74] = 326;
            this.PlayBoard.LocationsY[74] = 449;

            this.PlayBoard.LocationsX[75] = 297;
            this.PlayBoard.LocationsY[75] = 413;

            this.PlayBoard.LocationsX[76] = 258;
            this.PlayBoard.LocationsY[76] = 392;

            this.PlayBoard.LocationsX[77] = 225;
            this.PlayBoard.LocationsY[77] = 361;

            this.PlayBoard.LocationsX[78] = 230;
            this.PlayBoard.LocationsY[78] = 311;

            this.PlayBoard.LocationsX[79] = 262;
            this.PlayBoard.LocationsY[79] = 283;

            this.PlayBoard.LocationsX[80] = 308;
            this.PlayBoard.LocationsY[80] = 270;

            this.PlayBoard.LocationsX[81] = 352;
            this.PlayBoard.LocationsY[81] = 273;

            this.PlayBoard.LocationsX[82] = 394;
            this.PlayBoard.LocationsY[82] = 281;

            this.PlayBoard.LocationsX[83] = 438;
            this.PlayBoard.LocationsY[83] = 302;

            this.PlayBoard.LocationsX[84] = 479;
            this.PlayBoard.LocationsY[84] = 324;

            this.PlayBoard.LocationsX[85] = 521;
            this.PlayBoard.LocationsY[85] = 347;

            // STUCK #2
            this.PlayBoard.LocationsX[86] = 561;
            this.PlayBoard.LocationsY[86] = 370;

            this.PlayBoard.LocationsX[87] = 605;
            this.PlayBoard.LocationsY[87] = 386;

            this.PlayBoard.LocationsX[88] = 649;
            this.PlayBoard.LocationsY[88] = 400;

            this.PlayBoard.LocationsX[89] = 695;
            this.PlayBoard.LocationsY[89] = 411;

            this.PlayBoard.LocationsX[90] = 741;
            this.PlayBoard.LocationsY[90] = 417;

            this.PlayBoard.LocationsX[91] = 788;
            this.PlayBoard.LocationsY[91] = 425;

            // SPECIAL Lolly Pop
            this.PlayBoard.LocationsX[92] = 835;
            this.PlayBoard.LocationsY[92] = 426;

            this.PlayBoard.LocationsX[93] = 882;
            this.PlayBoard.LocationsY[93] = 426;

            this.PlayBoard.LocationsX[94] = 926;
            this.PlayBoard.LocationsY[94] = 413;

            this.PlayBoard.LocationsX[95] = 968;
            this.PlayBoard.LocationsY[95] = 397;

            this.PlayBoard.LocationsX[96] = 996;
            this.PlayBoard.LocationsY[96] = 363;

            this.PlayBoard.LocationsX[97] = 1005;
            this.PlayBoard.LocationsY[97] = 316;

            this.PlayBoard.LocationsX[98] = 992;
            this.PlayBoard.LocationsY[98] = 273;

            this.PlayBoard.LocationsX[99] = 956;
            this.PlayBoard.LocationsY[99] = 247;

            this.PlayBoard.LocationsX[100] = 919;
            this.PlayBoard.LocationsY[100] = 221;

            this.PlayBoard.LocationsX[101] = 903;
            this.PlayBoard.LocationsY[101] = 177;

            // SPECIAL ice cream
            this.PlayBoard.LocationsX[102] = 882;
            this.PlayBoard.LocationsY[102] = 137;

            this.PlayBoard.LocationsX[103] = 841;
            this.PlayBoard.LocationsY[103] = 117;

            this.PlayBoard.LocationsX[104] = 794;
            this.PlayBoard.LocationsY[104] = 131;

            this.PlayBoard.LocationsX[105] = 763;
            this.PlayBoard.LocationsY[105] = 163;

            this.PlayBoard.LocationsX[106] = 743;
            this.PlayBoard.LocationsY[106] = 208;

            this.PlayBoard.LocationsX[107] = 722;
            this.PlayBoard.LocationsY[107] = 248;

            this.PlayBoard.LocationsX[108] = 695;
            this.PlayBoard.LocationsY[108] = 285;

            this.PlayBoard.LocationsX[109] = 657;
            this.PlayBoard.LocationsY[109] = 312;

            this.PlayBoard.LocationsX[110] = 609;
            this.PlayBoard.LocationsY[110] = 318;

            this.PlayBoard.LocationsX[111] = 565;
            this.PlayBoard.LocationsY[111] = 302;

            this.PlayBoard.LocationsX[112] = 526;
            this.PlayBoard.LocationsY[112] = 282;

            this.PlayBoard.LocationsX[113] = 486;
            this.PlayBoard.LocationsY[113] = 255;

            this.PlayBoard.LocationsX[114] = 448;
            this.PlayBoard.LocationsY[114] = 230;

            this.PlayBoard.LocationsX[115] = 404;
            this.PlayBoard.LocationsY[115] = 216;

            this.PlayBoard.LocationsX[116] = 357;
            this.PlayBoard.LocationsY[116] = 209;

            this.PlayBoard.LocationsX[117] = 312;
            this.PlayBoard.LocationsY[117] = 213;

            this.PlayBoard.LocationsX[118] = 267;
            this.PlayBoard.LocationsY[118] = 221;

            // Stuck #3
            this.PlayBoard.LocationsX[119] = 223;
            this.PlayBoard.LocationsY[119] = 225;

            this.PlayBoard.LocationsX[120] = 179;
            this.PlayBoard.LocationsY[120] = 225;

            this.PlayBoard.LocationsX[121] = 138;
            this.PlayBoard.LocationsY[121] = 218;

            this.PlayBoard.LocationsX[122] = 102;
            this.PlayBoard.LocationsY[122] = 198;

            this.PlayBoard.LocationsX[123] = 81;
            this.PlayBoard.LocationsY[123] = 164;

            this.PlayBoard.LocationsX[124] = 77;
            this.PlayBoard.LocationsY[124] = 114;

            this.PlayBoard.LocationsX[125] = 90;
            this.PlayBoard.LocationsY[125] = 72;

            this.PlayBoard.LocationsX[126] = 125;
            this.PlayBoard.LocationsY[126] = 44;

            this.PlayBoard.LocationsX[127] = 167;
            this.PlayBoard.LocationsY[127] = 25;

            this.PlayBoard.LocationsX[128] = 211;
            this.PlayBoard.LocationsY[128] = 24;

            this.PlayBoard.LocationsX[129] = 253;
            this.PlayBoard.LocationsY[129] = 33;

            this.PlayBoard.LocationsX[130] = 291;
            this.PlayBoard.LocationsY[130] = 56;

            this.PlayBoard.LocationsX[131] = 327;
            this.PlayBoard.LocationsY[131] = 82;

            this.PlayBoard.LocationsX[132] = 363;
            this.PlayBoard.LocationsY[132] = 109;

            this.PlayBoard.LocationsX[133] = 403;
            this.PlayBoard.LocationsY[133] = 127;

            // Final square.
            this.PlayBoard.LocationsX[134] = 448;
            this.PlayBoard.LocationsY[134] = 147;

            // Had to fix the locations because they messed up after we set the picture box to the label parents.
            int z = 5;
            while (z < 134)
            {
                this.PlayBoard.LocationsX[z] -= 5;
                this.PlayBoard.LocationsY[z] -= 10;
                z++;
            }

            // End of plotting out points in array

            /* fill the locationcolor array with the correct color
            this will make location[1] = locationcolor[1]. EX) Location[1] = LocationColor[1], where LocationColor[1] = "Red" */
            int colorcounter = 0;
            int j = 1;
            while (colorcounter <= 20)
            {
                while (j <= 133)
                {
                    if (redLocations[colorcounter] == j)
                    {
                        this.PlayBoard.LocationsColor[j] = "Red";
                    }
                    else if (purpleLocations[colorcounter] == j)
                    {
                        this.PlayBoard.LocationsColor[j] = "Purple";
                    }
                    else if (yellowLocations[colorcounter] == j)
                    {
                        this.PlayBoard.LocationsColor[j] = "Yellow";
                    }
                    else if (blueLocations[colorcounter] == j)
                    {
                        this.PlayBoard.LocationsColor[j] = "Blue";
                    }
                    else if (orangeLocations[colorcounter] == j)
                    {
                        this.PlayBoard.LocationsColor[j] = "Orange";
                    }
                    else if (greenLocations[colorcounter] == j)
                    {
                        this.PlayBoard.LocationsColor[j] = "Green";
                    }

                    j++;
                }

                j = 0;
                colorcounter++;
            }

            // add the special locations to the array
            this.PlayBoard.LocationsColor[9] = "GingerbreadMan";
            this.PlayBoard.LocationsColor[20] = "Candy Cane";
            this.PlayBoard.LocationsColor[42] = "Gumdrop";
            this.PlayBoard.LocationsColor[69] = "Peanut Brittle";
            this.PlayBoard.LocationsColor[92] = "Lolly";
            this.PlayBoard.LocationsColor[102] = "Princess Frostine";
            this.PlayBoard.LocationsColor[133] = "Red";
            this.PlayBoard.LocationsColor[134] = "Finish";

            // testing the movement on some random locations
            this.lblLabel3.Location = new Point(62, 713);
            this.lblLabel4.Location = new Point(147, 801);
            this.lblLabel2.Location = new Point(62, 801);
            this.lblLabel1.Location = new Point(this.PlayBoard.LocationsX[1], this.PlayBoard.LocationsY[1]);
            if (this.PlayerList != null)
            { 
                if (this.PlayerList[0].IsComputer)
                {
                this.btnDraw.Text = "Start";
                }
            }
        }

        /// <summary>
        /// Method to close and exit
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult closeform = MessageBox.Show(
                "Are you sure you want to exit? All progress will be lost.",
                "Exit CandyLand?", 
                MessageBoxButtons.YesNo);
            if (closeform == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        /// <summary>
        /// Method to call next player.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnNextPlayer_Click(object sender, EventArgs e)
        {
            if (this.PlayerList != null)
            {
                if ((this.gamePiece.Location == new Point(this.playBoard.LocationsX[46], this.playBoard.LocationsY[46]) ||
                     this.gamePiece.Location == new Point(this.playBoard.LocationsX[86], this.playBoard.LocationsY[86]) ||
                     this.gamePiece.Location == new Point(this.playBoard.LocationsX[119], this.playBoard.LocationsY[119]))
                    && this.PlayerList[0].Stuck == false)
                {
                    // Set stuck to true.
                    this.PlayerList[0].Stuck = true;

                    // Add player to the bottom of the list.
                    this.PlayerList.Add(this.PlayerList[0]);

                    // Remove current player from list and send to bottom.
                    this.PlayerList.Remove(this.PlayerList[0]);

                    // Call the Current Player Turn method.
                    this.CurrentPlayerTurn();
                }
                else if ((this.gamePiece.Location == new Point(this.playBoard.LocationsX[46], this.playBoard.LocationsY[46]) ||
                          this.gamePiece.Location == new Point(this.playBoard.LocationsX[86], this.playBoard.LocationsY[86]) ||
                          this.gamePiece.Location == new Point(this.playBoard.LocationsX[119], this.playBoard.LocationsY[119]))
                         && this.PlayerList[0].Stuck)
                {
                    this.PlayerList[0].Stuck = false;

                    // Add player to the bottom of the list.
                    this.PlayerList.Add(this.PlayerList[0]);

                    // Remove current player from list and send to bottom.
                    this.PlayerList.Remove(this.PlayerList[0]);

                    // Call the Current Player Turn method.
                    this.CurrentPlayerTurn();
                }
                else
                {
                    this.PlayerList[0].Stuck = false;

                    // Add player to the bottom of the list.
                    this.PlayerList.Add(this.PlayerList[0]);

                    // Remove current player from list and send to bottom.
                    this.PlayerList.Remove(this.PlayerList[0]);

                    // Call the Current Player Turn method.
                    this.CurrentPlayerTurn();
                }
            }
            else
            {
                // Player list doesnt exist.
                // Enable the draw button.
                this.btnDraw.Enabled = true;
            }
        }

        /// <summary>
        /// Method to Set Round.
        /// </summary>
        private void SetRound()
        {
            // Increment round counter.
            this.round++;

            // Display round number in round label.
            this.lblRound.Text = "Round " + this.round;
        }

        /// <summary>
        /// Method to check if two players are on the same location, and if they are move one of them up(y) 50 
        /// </summary>
        private void CheckPlayers()
        {
            int currentlocation = 0;
            int i = 1;
            while (i < 135)
            {
                if (this.gamePiece.Location == new Point(this.PlayBoard.LocationsX[i], this.PlayBoard.LocationsY[i]))
                {
                    currentlocation = i;
                    break;
                }

                i++;
            }

                // If player 1 is on the same location as any other player then move player 1 ahead one space.
                if (this.lblLabel1.Location.Equals(lblLabel2.Location) || this.lblLabel1.Location.Equals(this.lblLabel3.Location) ||
                    this.lblLabel1.Location.Equals(this.lblLabel4.Location))
                {
                    this.lblLabel1.Location = new Point(this.PlayBoard.LocationsX[currentlocation + 1], this.PlayBoard.LocationsY[currentlocation + 1]);
                    pbxGameBoard.Refresh();
                }

                if (this.lblLabel2.Location.Equals(this.lblLabel3.Location) || this.lblLabel2.Location.Equals(this.lblLabel4.Location))
                {
                    this.lblLabel2.Location = new Point(this.PlayBoard.LocationsX[currentlocation + 1], this.PlayBoard.LocationsX[currentlocation + 1]);
                    pbxGameBoard.Refresh();
                }

                if (this.lblLabel3.Location.Equals(this.lblLabel4.Location))
                {
                    this.lblLabel3.Location = new Point(this.PlayBoard.LocationsX[currentlocation + 1], this.PlayBoard.LocationsY[currentlocation + 1]);
                    pbxGameBoard.Refresh();
                }
        }

        /// <summary>
        /// Method to call next player.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">EventArgs e.</param>
        private void BtnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For SinglePlayer:" + "\n" +  "\n" +
                            "Press the draw card button and your character will move. Continue until you reach the end." +
                            "\n" + "\n"
                            + "For MultiPlayer:" + "\n" + "\n" + "If all players are computers hit the start button to start the game." + 
                            "\n" + "For players, hit the draw card button to move, and then hit the next player turn button to move on to the next player."
                            + "\n" + "Human Players can also skip their turn by just pressing the next player turn button.");
        }
    }
}
