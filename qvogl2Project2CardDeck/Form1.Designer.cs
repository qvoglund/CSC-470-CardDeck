namespace qvogl2Project2CardDeck
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
            this.drawAmount = new System.Windows.Forms.TextBox();
            this.cardPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawAmount
            // 
            this.drawAmount.Location = new System.Drawing.Point(47, 10);
            this.drawAmount.Name = "drawAmount";
            this.drawAmount.Size = new System.Drawing.Size(37, 20);
            this.drawAmount.TabIndex = 1;
            // 
            // cardPictureBox
            // 
            this.cardPictureBox.Image = global::qvogl2Project2CardDeck.Properties.Resources.cardBack;
            this.cardPictureBox.Location = new System.Drawing.Point(12, 45);
            this.cardPictureBox.Name = "cardPictureBox";
            this.cardPictureBox.Size = new System.Drawing.Size(72, 100);
            this.cardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPictureBox.TabIndex = 2;
            this.cardPictureBox.TabStop = false;
            this.cardPictureBox.Click += new System.EventHandler(this.cardPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Draw:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardPictureBox);
            this.Controls.Add(this.drawAmount);
            this.Name = "Form1";
            this.Text = "Card Deck";
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox drawAmount;
        private System.Windows.Forms.PictureBox cardPictureBox;
        private System.Windows.Forms.Label label1;
    }
}

