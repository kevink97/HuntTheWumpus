using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WumpusTest
{
    public partial class TitleScreen : Form
    {
        GameController gc = new GameController();
        public TitleScreen()
        {
            InitializeComponent();
            //showBackground();
        }

        private void ConstructorButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WumpusGraphics graphics = new WumpusGraphics(this);
           // graphics.drawWumpus();
            InGame graphics = new InGame();
            graphics.Show();
            string response = Interaction.InputBox("Enter your name:", "Name", "firstName lastName", 0, 0);
            HighScore.name = response;
            this.Hide();
       
        }
        private void pictureBox1_Click(object sender, EventArgs e) {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HighScoreDisplay hsd = new HighScoreDisplay();
            hsd.Show();
            hsd.displayHighScores(HighScore.displayHighScore());

            //highscore.updateHighScoreInFile();
        }

        private void TitleScreen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Sorry judges. Maybe Next Time.");
        }
       // public void showBackground()
        //{
       //     hamster.ImageLocation = "hamster.jpg";
       // }

    }
}
