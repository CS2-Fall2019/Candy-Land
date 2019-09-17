namespace Game_CandyLand
{
    partial class Form1
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
            this.SinglePlayerbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SinglePlayerbutton
            // 
            this.SinglePlayerbutton.Location = new System.Drawing.Point(77, 82);
            this.SinglePlayerbutton.Name = "SinglePlayerbutton";
            this.SinglePlayerbutton.Size = new System.Drawing.Size(200, 55);
            this.SinglePlayerbutton.TabIndex = 0;
            this.SinglePlayerbutton.Text = "Single Player";
            this.SinglePlayerbutton.UseVisualStyleBackColor = true;
            this.SinglePlayerbutton.Click += new System.EventHandler(this.SinglePlayerbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SinglePlayerbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SinglePlayerbutton;
    }
}

