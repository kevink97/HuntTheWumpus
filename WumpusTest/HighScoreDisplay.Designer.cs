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
            this.SuspendLayout();
            // 
            // HighScoreTitle
            // 
            this.HighScoreTitle.AutoSize = true;
            this.HighScoreTitle.Font = new System.Drawing.Font("Roboto Lt", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreTitle.Location = new System.Drawing.Point(297, 9);
            this.HighScoreTitle.Name = "HighScoreTitle";
            this.HighScoreTitle.Size = new System.Drawing.Size(212, 44);
            this.HighScoreTitle.TabIndex = 0;
            this.HighScoreTitle.Text = "High Score";
            // 
            // ListOfHighScore
            // 
            this.ListOfHighScore.AutoSize = true;
            this.ListOfHighScore.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfHighScore.Location = new System.Drawing.Point(40, 53);
            this.ListOfHighScore.Name = "ListOfHighScore";
            this.ListOfHighScore.Size = new System.Drawing.Size(528, 29);
            this.ListOfHighScore.TabIndex = 1;
            this.ListOfHighScore.Text = "No high scores are available! Go and play a game!";
            this.ListOfHighScore.Click += new System.EventHandler(this.ListOfHighScore_Click);
            // 
            // HighScoreDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 419);
            this.Controls.Add(this.ListOfHighScore);
            this.Controls.Add(this.HighScoreTitle);
            this.Name = "HighScoreDisplay";
            this.Text = "HighScoreDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HighScoreTitle;
        private System.Windows.Forms.Label ListOfHighScore;
    }
}