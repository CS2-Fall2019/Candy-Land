namespace Game_CandyLand
{
    partial class Multiplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multiplayer));
            this.btnStartMultiplayer = new System.Windows.Forms.Button();
            this.cboPlayers = new System.Windows.Forms.ComboBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblComputerPlayers = new System.Windows.Forms.Label();
            this.cboComputerPlayers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnStartMultiplayer
            // 
            this.btnStartMultiplayer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStartMultiplayer.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStartMultiplayer.FlatAppearance.BorderSize = 0;
            this.btnStartMultiplayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStartMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMultiplayer.ForeColor = System.Drawing.Color.Black;
            this.btnStartMultiplayer.Location = new System.Drawing.Point(124, 218);
            this.btnStartMultiplayer.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartMultiplayer.Name = "btnStartMultiplayer";
            this.btnStartMultiplayer.Size = new System.Drawing.Size(145, 62);
            this.btnStartMultiplayer.TabIndex = 4;
            this.btnStartMultiplayer.Text = "&Start Game";
            this.btnStartMultiplayer.UseVisualStyleBackColor = false;
            this.btnStartMultiplayer.Click += new System.EventHandler(this.btnStartMultiplayer_Click);
            // 
            // cboPlayers
            // 
            this.cboPlayers.FormattingEnabled = true;
            this.cboPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cboPlayers.Location = new System.Drawing.Point(137, 97);
            this.cboPlayers.Name = "cboPlayers";
            this.cboPlayers.Size = new System.Drawing.Size(121, 21);
            this.cboPlayers.TabIndex = 5;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.BackColor = System.Drawing.Color.MistyRose;
            this.lblPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(56, 63);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(276, 20);
            this.lblPlayers.TabIndex = 6;
            this.lblPlayers.Text = "How many players do you want to have?";
            // 
            // lblComputerPlayers
            // 
            this.lblComputerPlayers.AutoSize = true;
            this.lblComputerPlayers.BackColor = System.Drawing.Color.MistyRose;
            this.lblComputerPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComputerPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerPlayers.Location = new System.Drawing.Point(56, 132);
            this.lblComputerPlayers.Name = "lblComputerPlayers";
            this.lblComputerPlayers.Size = new System.Drawing.Size(275, 20);
            this.lblComputerPlayers.TabIndex = 8;
            this.lblComputerPlayers.Text = "Number of computer controlled players?";
            // 
            // cboComputerPlayers
            // 
            this.cboComputerPlayers.FormattingEnabled = true;
            this.cboComputerPlayers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cboComputerPlayers.Location = new System.Drawing.Point(137, 165);
            this.cboComputerPlayers.Name = "cboComputerPlayers";
            this.cboComputerPlayers.Size = new System.Drawing.Size(121, 21);
            this.cboComputerPlayers.TabIndex = 7;
            // 
            // Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 304);
            this.Controls.Add(this.lblComputerPlayers);
            this.Controls.Add(this.cboComputerPlayers);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.cboPlayers);
            this.Controls.Add(this.btnStartMultiplayer);
            this.Name = "Multiplayer";
            this.Text = "Multiplayer";
            this.Load += new System.EventHandler(this.Multiplayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartMultiplayer;
        private System.Windows.Forms.ComboBox cboPlayers;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblComputerPlayers;
        private System.Windows.Forms.ComboBox cboComputerPlayers;
    }
}