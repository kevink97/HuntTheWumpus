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
        GameController gc = new GameController();
        public Form1()
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
            gc.newGame();
       
        }
        private void pictureBox1_Click(object sender, EventArgs e) {
        }
       // public void showBackground()
        //{
       //     hamster.ImageLocation = "hamster.jpg";
       // }

    }
}
