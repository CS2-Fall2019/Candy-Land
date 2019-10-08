//-----------------------------------------------------------------------
// <copyright file="Form1.Designer.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Game_CandyLand
{
    /// <summary>
    /// The CandyLandGame class (designer).
    /// </summary>
    public partial class CandyLandGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Single Player button.
        /// </summary>
        private System.Windows.Forms.Button btnSinglePlayer;

        /// <summary>
        /// About button.
        /// </summary>
        private System.Windows.Forms.Button btnAbout;

        /// <summary>
        /// Multiplayer button.
        /// </summary>
        private System.Windows.Forms.Button btnMultiplayer;

        #region Windows Form Designer generated code

        #endregion
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandyLandGame));
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //// 
            // btnSinglePlayer
            //// 
            this.btnSinglePlayer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSinglePlayer.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSinglePlayer.FlatAppearance.BorderSize = 0;
            //// this.btnSinglePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSinglePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            this.btnSinglePlayer.ForeColor = System.Drawing.Color.Black;
            this.btnSinglePlayer.Location = new System.Drawing.Point(23, 77);
            this.btnSinglePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(103, 42);
            this.btnSinglePlayer.TabIndex = 0;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.BtnSinglePlayer_Click);
            //// 
            // btnAbout
            //// 
            this.btnAbout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Location = new System.Drawing.Point(134, 132);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(103, 42);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            //// 
            // btnMultiplayer
            //// 
            this.btnMultiplayer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMultiplayer.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMultiplayer.FlatAppearance.BorderSize = 0;
            ////this.btnMultiplayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMultiplayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 255); 
            this.btnMultiplayer.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplayer.Location = new System.Drawing.Point(253, 77);
            this.btnMultiplayer.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(103, 42);
            this.btnMultiplayer.TabIndex = 2;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = false;
            this.btnMultiplayer.Click += new System.EventHandler(this.BtnMultiplayer_Click);
            //// 
            // CandyLandGame
            //// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage"); 
            this.ClientSize = new System.Drawing.Size(377, 283);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSinglePlayer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CandyLandGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandyLand";
            this.ResumeLayout(false);
        }
    }
}
