//-----------------------------------------------------------------------
// <copyright file="PlayerBoard.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Game_CandyLand
{
    partial class PlayerBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerBoard));
            this.GameBoard_picbox = new System.Windows.Forms.PictureBox();
            this.Draw_btn = new System.Windows.Forms.Button();
            this.Start_btn = new System.Windows.Forms.Button();
            this.outputlog_lbl = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imgListCards = new System.Windows.Forms.ImageList(this.components);
            this.pbxCardDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // GameBoard_picbox
            // 
            this.GameBoard_picbox.Image = ((System.Drawing.Image)(resources.GetObject("GameBoard_picbox.Image")));
            this.GameBoard_picbox.Location = new System.Drawing.Point(8, 9);
            this.GameBoard_picbox.Margin = new System.Windows.Forms.Padding(2);
            this.GameBoard_picbox.MaximumSize = new System.Drawing.Size(1211, 882);
            this.GameBoard_picbox.MinimumSize = new System.Drawing.Size(1211, 882);
            this.GameBoard_picbox.Name = "GameBoard_picbox";
            this.GameBoard_picbox.Size = new System.Drawing.Size(1211, 882);
            this.GameBoard_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GameBoard_picbox.TabIndex = 0;
            this.GameBoard_picbox.TabStop = false;
            // 
            // Draw_btn
            // 
            this.Draw_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Draw_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Draw_btn.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw_btn.ForeColor = System.Drawing.Color.HotPink;
            this.Draw_btn.Location = new System.Drawing.Point(1251, 160);
            this.Draw_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Draw_btn.Name = "Draw_btn";
            this.Draw_btn.Size = new System.Drawing.Size(105, 45);
            this.Draw_btn.TabIndex = 1;
            this.Draw_btn.Text = "Draw Card";
            this.Draw_btn.UseVisualStyleBackColor = false;
            this.Draw_btn.Click += new System.EventHandler(this.Draw_btn_Click);
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Start_btn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.ForeColor = System.Drawing.Color.HotPink;
            this.Start_btn.Location = new System.Drawing.Point(1311, 233);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(67, 31);
            this.Start_btn.TabIndex = 2;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // outputlog_lbl
            // 
            this.outputlog_lbl.AutoSize = true;
            this.outputlog_lbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.outputlog_lbl.Location = new System.Drawing.Point(12, 893);
            this.outputlog_lbl.Name = "outputlog_lbl";
            this.outputlog_lbl.Size = new System.Drawing.Size(0, 13);
            this.outputlog_lbl.TabIndex = 3;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Exit_btn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.HotPink;
            this.Exit_btn.Location = new System.Drawing.Point(1223, 233);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(67, 31);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(1246, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(1334, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 47);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(743, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(1344, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "Player4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgListCards
            // 
            this.imgListCards.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCards.ImageStream")));
            this.imgListCards.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCards.Images.SetKeyName(0, "Green.png");
            this.imgListCards.Images.SetKeyName(1, "Double Green.png");
            this.imgListCards.Images.SetKeyName(2, "Red.png");
            this.imgListCards.Images.SetKeyName(3, "Double Red.png");
            this.imgListCards.Images.SetKeyName(4, "Orange.png");
            this.imgListCards.Images.SetKeyName(5, "Double Orange.png");
            this.imgListCards.Images.SetKeyName(6, "Blue.png");
            this.imgListCards.Images.SetKeyName(7, "Double Blue.png");
            this.imgListCards.Images.SetKeyName(8, "Purple.jpeg");
            this.imgListCards.Images.SetKeyName(9, "Double Purple.jpeg");
            this.imgListCards.Images.SetKeyName(10, "Yellow.png");
            this.imgListCards.Images.SetKeyName(11, "Double Yellow.png");
            this.imgListCards.Images.SetKeyName(12, "Peppermint.png");
            this.imgListCards.Images.SetKeyName(13, "Peanut.png");
            this.imgListCards.Images.SetKeyName(14, "Lollipop.png");
            this.imgListCards.Images.SetKeyName(15, "Ice Cream.png");
            this.imgListCards.Images.SetKeyName(16, "Gum Drop.png");
            this.imgListCards.Images.SetKeyName(17, "GingerBreadMan.png");
            // 
            // pbxCardDisplay
            // 
            this.pbxCardDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCardDisplay.Location = new System.Drawing.Point(1288, 513);
            this.pbxCardDisplay.Name = "pbxCardDisplay";
            this.pbxCardDisplay.Size = new System.Drawing.Size(100, 50);
            this.pbxCardDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCardDisplay.TabIndex = 9;
            this.pbxCardDisplay.TabStop = false;
            // 
            // PlayerBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1467, 902);
            this.Controls.Add(this.pbxCardDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.outputlog_lbl);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Draw_btn);
            this.Controls.Add(this.GameBoard_picbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(926, 795);
            this.Name = "PlayerBoard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandyLand";
            this.Load += new System.EventHandler(this.PlayerBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameBoard_picbox;
        private System.Windows.Forms.Button Draw_btn;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Label outputlog_lbl;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imgListCards;
        private System.Windows.Forms.PictureBox pbxCardDisplay;
    }
}