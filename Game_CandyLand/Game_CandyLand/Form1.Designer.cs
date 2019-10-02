namespace Game_CandyLand
{
    partial class CandyLandGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandyLandGame));
            this.SinglePlayerbutton = new System.Windows.Forms.Button();
            this.Aboutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SinglePlayerbutton
            // 
            this.SinglePlayerbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SinglePlayerbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SinglePlayerbutton.FlatAppearance.BorderSize = 0;
            this.SinglePlayerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SinglePlayerbutton.ForeColor = System.Drawing.Color.Black;
            this.SinglePlayerbutton.Location = new System.Drawing.Point(130, 81);
            this.SinglePlayerbutton.Margin = new System.Windows.Forms.Padding(2);
            this.SinglePlayerbutton.Name = "SinglePlayerbutton";
            this.SinglePlayerbutton.Size = new System.Drawing.Size(103, 42);
            this.SinglePlayerbutton.TabIndex = 0;
            this.SinglePlayerbutton.Text = "Single Player";
            this.SinglePlayerbutton.UseVisualStyleBackColor = false;
            this.SinglePlayerbutton.Click += new System.EventHandler(this.SinglePlayerbutton_Click);
            // 
            // Aboutbutton
            // 
            this.Aboutbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Aboutbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Aboutbutton.FlatAppearance.BorderSize = 0;
            this.Aboutbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Aboutbutton.ForeColor = System.Drawing.Color.Black;
            this.Aboutbutton.Location = new System.Drawing.Point(130, 145);
            this.Aboutbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Aboutbutton.Name = "Aboutbutton";
            this.Aboutbutton.Size = new System.Drawing.Size(103, 42);
            this.Aboutbutton.TabIndex = 1;
            this.Aboutbutton.Text = "About";
            this.Aboutbutton.UseVisualStyleBackColor = false;
            this.Aboutbutton.Click += new System.EventHandler(this.Aboutbutton_Click_1);
            // 
            // CandyLandGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(377, 283);
            this.Controls.Add(this.Aboutbutton);
            this.Controls.Add(this.SinglePlayerbutton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CandyLandGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandyLand";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SinglePlayerbutton;
        private System.Windows.Forms.Button Aboutbutton;
    }
}

