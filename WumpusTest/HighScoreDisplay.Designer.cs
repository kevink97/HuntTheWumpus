namespace WumpusTest
{
    partial class HighScoreDisplay
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
            this.HighScoreTitle = new System.Windows.Forms.Label();
            this.ListOfHighScore = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // HighScoreTitle
            // 
            this.HighScoreTitle.AutoSize = true;
            this.HighScoreTitle.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreTitle.Location = new System.Drawing.Point(297, -1);
            this.HighScoreTitle.Name = "HighScoreTitle";
            this.HighScoreTitle.Size = new System.Drawing.Size(232, 58);
            this.HighScoreTitle.TabIndex = 0;
            this.HighScoreTitle.Text = "High Score";
            // 
            // ListOfHighScore
            // 
            this.ListOfHighScore.AutoSize = true;
            this.ListOfHighScore.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfHighScore.Location = new System.Drawing.Point(36, 57);
            this.ListOfHighScore.Name = "ListOfHighScore";
            this.ListOfHighScore.Size = new System.Drawing.Size(450, 33);
            this.ListOfHighScore.TabIndex = 1;
            this.ListOfHighScore.Text = "No high scores are available! Go and play a game!";
            this.ListOfHighScore.Click += new System.EventHandler(this.ListOfHighScore_Click);
            // 
            // background
            // 
            this.background.Image = global::WumpusTest.Properties.Resources.seagull;
            this.background.Location = new System.Drawing.Point(-3, -1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(840, 429);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 2;
            this.background.TabStop = false;
            // 
            // HighScoreDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 419);
            this.Controls.Add(this.ListOfHighScore);
            this.Controls.Add(this.HighScoreTitle);
            this.Controls.Add(this.background);
            this.Name = "HighScoreDisplay";
            this.Text = "HighScoreDisplay";
            this.Load += new System.EventHandler(this.HighScoreDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void displayHighScores(string listOfscores)
        {
            this.ListOfHighScore.Text = listOfscores;
        }
        #endregion

        private System.Windows.Forms.Label HighScoreTitle;
        private System.Windows.Forms.Label ListOfHighScore;
        private System.Windows.Forms.PictureBox background;
    }
}