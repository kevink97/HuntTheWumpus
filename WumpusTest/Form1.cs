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
    public partial class Form1 : Form
    {
        private GameController _GameController;
        private static int numberOfCave = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void newGame_Click(object sender, EventArgs e)
        {
            _GameController = new GameController();
        }

        private void highScore_Click(object sender, EventArgs e)
        {
            //HighScore _HighScore = new HighScore();
            //_HighScore.showDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
