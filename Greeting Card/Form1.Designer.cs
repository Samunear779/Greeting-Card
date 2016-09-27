namespace Greeting_Card
{
    partial class greetingCard
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
            this.cardTitle = new System.Windows.Forms.Label();
            this.happyImage = new System.Windows.Forms.PictureBox();
            this.funnyTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.happyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cardTitle
            // 
            this.cardTitle.AutoSize = true;
            this.cardTitle.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTitle.ForeColor = System.Drawing.Color.White;
            this.cardTitle.Location = new System.Drawing.Point(24, 62);
            this.cardTitle.Name = "cardTitle";
            this.cardTitle.Size = new System.Drawing.Size(319, 40);
            this.cardTitle.TabIndex = 0;
            this.cardTitle.Text = "Happy Greeting Card";
            // 
            // happyImage
            // 
            this.happyImage.Image = global::Greeting_Card.Properties.Resources._7;
            this.happyImage.Location = new System.Drawing.Point(114, 154);
            this.happyImage.Name = "happyImage";
            this.happyImage.Size = new System.Drawing.Size(138, 166);
            this.happyImage.TabIndex = 1;
            this.happyImage.TabStop = false;
            // 
            // funnyTitle
            // 
            this.funnyTitle.AutoSize = true;
            this.funnyTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funnyTitle.ForeColor = System.Drawing.Color.White;
            this.funnyTitle.Location = new System.Drawing.Point(-6, 346);
            this.funnyTitle.Name = "funnyTitle";
            this.funnyTitle.Size = new System.Drawing.Size(379, 36);
            this.funnyTitle.TabIndex = 2;
            this.funnyTitle.Text = "Someone Actually Likes You";
            // 
            // greetingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(371, 469);
            this.Controls.Add(this.funnyTitle);
            this.Controls.Add(this.happyImage);
            this.Controls.Add(this.cardTitle);
            this.Name = "greetingCard";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.happyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cardTitle;
        private System.Windows.Forms.PictureBox happyImage;
        private System.Windows.Forms.Label funnyTitle;
    }
}

