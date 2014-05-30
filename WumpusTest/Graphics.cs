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
    //get each button to work....maybe change text of button(?) if it isnt too much for you(?)
    public partial class Graphics : Form
    {
        GameController gc = new GameController();
        Random rand = new Random();
        int[] surroundingRoom;
        //int score = getPlayer().getScore();
        public Graphics()
        {
            InitializeComponent();
            gc.newGame();
            surroundingRoom = gc.getMap().getConnectedRooms(gc.getMap().getPlayerPosition(), 2);
            //UpdateGraphics(cave1, cave2, cave3, bats);
        }

        public void runThingsInsideCave()
        {
            if(gc.getMap().isPitNear())
            {
                var x = MessageBox.Show("I smell a draft!");
            }
            if (gc.getMap().isWumpusNear())
            {
                var x = MessageBox.Show("I smell a Wumpus!");
            }
            if (gc.getMap().areBatsNear())
            {
                var x = MessageBox.Show("I smell bats!");
            }
        }

        private void Graphics_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void UpdateGraphics(int cave1num, int cave2, int cave3, Boolean batsShow, Boolean pitShow, Boolean wumpusShow)
        {
            cave1.Text = Convert.ToString(cave1num);
            if (batsShow)
            {
                bat.Visible = true;
            }
            arrowCount.Text = "Arrows" + Convert.ToString(gc.getPlayerInfo().getArrows());
            if (pitShow)
            {
                pit.Visible = true;
            }
            if (wumpusShow)
            {
                wumpus.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buyArrows_Click(object sender, EventArgs e)
        {
            bool money = gc.buyArrows();
            if (!money)
            {
                int s = gc.getPlayerInfo().getGold();
                MessageBox.Show("Not enough money: " + s);
            }

        }

        private void cave2_Click(object sender, EventArgs e)
        {
            gc.move(Convert.ToInt32(cave2.Text));
        }

        private void cave3_Click(object sender, EventArgs e)
        {
            gc.move(Convert.ToInt32(cave3.Text));
        }

        private void cave1_Click_1(object sender, EventArgs e)
        {
            gc.move(Convert.ToInt32(cave1.Text));

        }

        private void score_Click(object sender, EventArgs e)
        {
            score.Text = "Score" + Convert.ToString(gc.getPlayerInfo().getScore());
        }

        private void gold_Click(object sender, EventArgs e)
        {
            gold.Text = "Gold" + Convert.ToString(gc.getPlayerInfo().getGold());

        }

        private void pit_Click(object sender, EventArgs e)
        {

        }

        private void CurrentRoomNum_Click(object sender, EventArgs e)
        {
            CurrentRoomNum.Text = Convert.ToString(gc.getMap().getPlayerPosition());
        }

        private void wumpus_Click(object sender, EventArgs e)
        {

        }

        private void shootArrow_Click(object sender, EventArgs e)
        {
            //gc.getPlayerInfo. SHOOT ARROW
        }



    }
}
