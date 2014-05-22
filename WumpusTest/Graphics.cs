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
    public partial class Graphics : Form
    {
        GameController gc = new GameController();
        Random rand = new Random();

        public Graphics()
        {
            InitializeComponent();
            gc.newGame();
            //UpdateGraphics(cave1, cave2, cave3, bats);
        }

        private void Graphics_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void UpdateGraphics(int cave1, int cave2, int cave3){
            
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bats_Click(object sender, EventArgs e)
        {

        }

        private void bat_Click(object sender, EventArgs e)
        {
            int a=rand.Next(10);
        
            if(a==1)
            {
                this.Hide();
            }
            ///Bats show up or not
        }

        private void right_Click(object sender, EventArgs e)
        {
            //right_Click.
        }

        private void buyArrows_Click(object sender, EventArgs e)
        {
            bool money=gc.buyArrows();
            if(!money)
            {
                int s = gc.getPlayerInfo().getGold();
                MessageBox.Show("Not enough money: " + s);
            }
           
        }

        private void arrowCount_Click(object sender, EventArgs e)
        {
            gc.getPlayerInfo().getArrows();
        }

        private void forward_Click(object sender, EventArgs e)
        {

        }


    }
}
