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
    public partial class TriviaForm1 : Form
    {
        public bool WonGame { get; private set; }
        public TriviaForm1()
        {
            InitializeComponent();
        }

        int counter = 0;

        private void button1_Click(object sender, EventArgs e, Color button1color)
        {
            counter++;

            continueGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            counter++;
        }

        private void button2_Click(object sender, EventArgs e, Color button2color)
        {
            counter++;

            continueGame();
        }

        private void button3_Click(object sender, EventArgs e, Color button3color)
        {
            counter++;

            continueGame();
        }

        private void button4_Click(object sender, EventArgs e, Color buttoncolor)
        {
            counter++;

            continueGame();
        }

        private void button5_Click(object sender, EventArgs e, Color button5color)
        {
            counter++;

            continueGame();
        }

        private void button6_Click(object sender, EventArgs e, Color button6color)
        {
            counter++;

            continueGame();
        }

        private void button7_Click(object sender, EventArgs e, Color button7color)
        {
            counter++;

            continueGame();
        }

        private void button8_Click(object sender, EventArgs e, Color button8color)
        {
            counter++;

            continueGame();
        }

        private void button9_Click(object sender, EventArgs e, Color button9color)
        {
            counter++;

            continueGame();
        }

        private bool continueGame()
        {
            if (isAllBlue())
            {
                this.Close();
                return false;
            }


            if (counter > 60)
            {
                this.Close();
                return false;
            }
            return true;

        }

    }
}
