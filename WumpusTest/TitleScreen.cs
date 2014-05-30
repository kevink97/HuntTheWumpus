using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class TitleScreen : Form
    {
        GameController gc = new GameController();
        public TitleScreen()
        {
            InitializeComponent();
            //showBackground();
            Graphics graphics = new Graphics();
        }

        private void ConstructorButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WumpusGraphics graphics = new WumpusGraphics(this);
           // graphics.drawWumpus();
            Graphics graphics = new Graphics();
            graphics.Show();
            this.Hide();
       
        }
        private void pictureBox1_Click(object sender, EventArgs e) {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HighScore highscore = new HighScore();
            HighScoreDisplay hsd = new HighScoreDisplay();
            
            highscore.addHighScore("MYNAME", 600);
            hsd.Show();
            hsd.displayHighScores(highscore.displayHighScore());
            //highscore.addHighScore("MYNAME", 600);

            highscore.updateHighScoreInFile();
        }

        private void TitleScreen_Load(object sender, EventArgs e)
        {

        }
       // public void showBackground()
        //{
       //     hamster.ImageLocation = "hamster.jpg";
       // }

    }
}
