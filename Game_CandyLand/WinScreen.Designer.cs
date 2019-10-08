//-----------------------------------------------------------------------
// <copyright file="WinScreen.Designer.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Game_CandyLand
{
    /// <summary>
    /// Class to represent the Winscreen form.
    /// </summary>
    public partial class WinScreen
    {
        /// <summary>
        /// Win label.
        /// </summary>
        public System.Windows.Forms.Label LblWin;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// New single player game button.
        /// </summary>
        private System.Windows.Forms.Button btnNewGame;

        /// <summary>
        /// Exit Button.
        /// </summary>
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        /// New multiplayer game button.
        /// </summary>
        private System.Windows.Forms.Button btnNewMultiplayerGame;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LblWin = new System.Windows.Forms.Label();
            this.btnNewMultiplayerGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(34, 98);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(1);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(80, 53);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Single Player Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(204, 98);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 53);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblWin
            // 
            this.LblWin.AutoSize = true;
            this.LblWin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWin.ForeColor = System.Drawing.Color.Black;
            this.LblWin.Location = new System.Drawing.Point(34, 53);
            this.LblWin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblWin.Name = "LblWin";
            this.LblWin.Size = new System.Drawing.Size(261, 26);
            this.LblWin.TabIndex = 2;
            this.LblWin.Text = "Congratulations player 1 wins!";
            // 
            // btnNewMultiplayerGame
            // 
            this.btnNewMultiplayerGame.Location = new System.Drawing.Point(116, 98);
            this.btnNewMultiplayerGame.Margin = new System.Windows.Forms.Padding(1);
            this.btnNewMultiplayerGame.Name = "btnNewMultiplayerGame";
            this.btnNewMultiplayerGame.Size = new System.Drawing.Size(82, 53);
            this.btnNewMultiplayerGame.TabIndex = 3;
            this.btnNewMultiplayerGame.Text = "New Multiplayer Game";
            this.btnNewMultiplayerGame.UseVisualStyleBackColor = true;
            this.btnNewMultiplayerGame.Click += new System.EventHandler(this.BtnNewMultiplayerGame_Click);
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(312, 196);
            this.Controls.Add(this.btnNewMultiplayerGame);
            this.Controls.Add(this.LblWin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "WinScreen";
            this.Text = "WinScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}