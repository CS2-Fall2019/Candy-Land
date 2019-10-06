namespace Game_CandyLand
{
    partial class WinScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.btnNewSingleGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelWin = new System.Windows.Forms.Label();
            this.btnNewMultiplayerGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewSingleGame
            // 
            this.btnNewSingleGame.Location = new System.Drawing.Point(90, 233);
            this.btnNewSingleGame.Name = "btnNewSingleGame";
            this.btnNewSingleGame.Size = new System.Drawing.Size(214, 126);
            this.btnNewSingleGame.TabIndex = 0;
            this.btnNewSingleGame.Text = "New Single Player Game";
            this.btnNewSingleGame.UseVisualStyleBackColor = true;
            this.btnNewSingleGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(545, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(214, 126);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.ForeColor = System.Drawing.Color.Black;
            this.labelWin.Location = new System.Drawing.Point(90, 127);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(669, 57);
            this.labelWin.TabIndex = 2;
            this.labelWin.Text = "Congratulations player 1 wins!";
            // 
            // btnNewMultiplayerGame
            // 
            this.btnNewMultiplayerGame.Location = new System.Drawing.Point(310, 233);
            this.btnNewMultiplayerGame.Name = "btnNewMultiplayerGame";
            this.btnNewMultiplayerGame.Size = new System.Drawing.Size(220, 126);
            this.btnNewMultiplayerGame.TabIndex = 3;
            this.btnNewMultiplayerGame.Text = "New Multiplayer Game";
            this.btnNewMultiplayerGame.UseVisualStyleBackColor = true;
            this.btnNewMultiplayerGame.Click += new System.EventHandler(this.btnNewMultiplayerGame_Click);
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(831, 468);
            this.Controls.Add(this.btnNewMultiplayerGame);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewSingleGame);
            this.Name = "WinScreen";
            this.Text = "WinScreen";
            this.Load += new System.EventHandler(this.WinScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewSingleGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewMultiplayerGame;
        public System.Windows.Forms.Label labelWin;
    }
}