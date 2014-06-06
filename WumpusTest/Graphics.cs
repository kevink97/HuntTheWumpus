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
    //get each button to work....maybe change text of button(?) if it isnt too much for you(?)
    public partial class InGame : Form
    {
        GameController gc = new GameController();
        Random rand = new Random();
        int[] surroundingRoom;
        //int score = getPlayer().getScore();
        public InGame()
        {
            InitializeComponent();
            gc.newGame();
            
            var pos = this.PointToScreen(arrowCount.Location);
            pos = background.PointToClient(pos);
            arrowCount.Parent = background;
            arrowCount.Location = pos;
            arrowCount.BackColor = Color.Transparent;
            
            var pos2 = this.PointToScreen(gold.Location);
            pos2 = background.PointToClient(pos2);
            gold.Parent = background;
            gold.Location = pos2;
            gold.BackColor = Color.Transparent;
            
            var pos3 = this.PointToScreen(score.Location);
            pos3 = background.PointToClient(pos3);
            score.Parent = background;
            score.Location = pos3;
            score.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(CurrentRoomNum.Location);
            pos4 = background.PointToClient(pos4);
            CurrentRoomNum.Parent = background;
            CurrentRoomNum.Location = pos4;
            CurrentRoomNum.BackColor = Color.Transparent;

            update();
            //UpdateGraphics(cave1, cave2, cave3, bats);
        }

        private void update()
        {
            surroundingRoom = gc.getMap().getConnectedRooms(gc.getMap().getPlayerPosition(), 1);
            int cave1Int = surroundingRoom[0];
            int cave2Int = surroundingRoom[1];
            int cave3Int = surroundingRoom[2];
            int currentRoom = gc.getMap().getPlayerPosition();
            int scoreVal = gc.getPlayerInfo().getScore();
            int goldVal = gc.getPlayerInfo().getGold();
            int arrowVal = gc.getPlayerInfo().getArrows();

            cavet1.Text = cave1Int.ToString();
            cavet2.Text = cave2Int.ToString();
            cavet3.Text = cave3Int.ToString();
            score.Text = "score: " + scoreVal.ToString();
            gold.Text = "gold: " + goldVal.ToString();
            arrowCount.Text = "arrows: " + arrowVal.ToString();
            const String shootT = "shoot at: ";
            arrowt1.Text = shootT + cave1Int.ToString();
            arrowt2.Text = shootT + cave2Int.ToString();
            arrowt3.Text = shootT + cave3Int.ToString();
            CurrentRoomNum.Text = "Current Room: " + currentRoom;
            Console.WriteLine("pit: " + printArray(gc.getMap().getPitPosition()));
            Console.WriteLine("bat: " + printArray(gc.getMap().getBatPosition()));
            Console.WriteLine("wumpus: " + gc.getMap().getWumpusPosition().ToString());
            Console.WriteLine("player: " + gc.getMap().getPlayerPosition().ToString());

            if(gc.getMap().isWumpusWithPlayer())
            {
                shark.BringToFront();
                shark.Visible = true;
                var meesage = MessageBox.Show("YOU CANT FIGHT HIM :(\nhe is too strong.\nWumpus will run away.");
                gc.getMap().generateRandomWumpusPosition();
                shark.Visible = false;
                update();
                /*TRIVIA?
                var message = MessageBox.Show("YOU ARE WITH THE invisible WUMPUS...OH NO D:");

                
                TriviaForm1 trivia = new TriviaForm1();
                trivia.ShowDialog();
                bool wonTrivia = trivia.WonGame;
                */
                //TODO: implement a way to pop up trivia.
            }
            if(gc.getMap().isPitWithPlayer())
            {
                label1.BringToFront();
                label1.Visible = true;
                var message = MessageBox.Show("ouchie..you died in the PIT :( \nGame Over..sorry");
                TitleScreen form = new TitleScreen();
                gc.getHighScore().addHighScore(gc.getPlayerInfo().getScore());
                form.Show();
                form.Activate();
                this.Hide();
            }
            if(gc.getMap().isBatWithPlayer())
            {
                bats.Visible = true;
                gc.getMap().generateRandomPlayerPosition();
                String position = gc.getMap().getPlayerPosition().ToString();
                var message = MessageBox.Show("watch out..there are invisible bats.\nyou will now be teleported to: cave " + position);
                bats.Visible = false;
                update();
            }
            if(gc.getMap().areBatsNear())
            {
                var message = MessageBox.Show("I hear those horrible bats");
            }
            if(gc.getMap().isPitNear())
            {
                var message = MessageBox.Show("My pit senses are tingling");
            }
            if(gc.getMap().isWumpusNear())
            {
                var message = MessageBox.Show("I HEAR THE DEADLY WUMPUS");
            }
        }

        private String printArray(int[] array)
        {
            String s = "";
            for(int i = 0; i< array.Length; i++)
            {
                s += array[i].ToString() + ", ";
            }
            return s;
        }

        public void runThingsInsideCave()
        {
            if(gc.getMap().isPitNear())
            {
                var x = MessageBox.Show("I smell a pit!");
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
            cavet1.Parent = background;
            cavet1.BackColor = Color.Transparent;
            cavet2.Parent = background;
            cavet2.BackColor = Color.Transparent;
            cavet3.Parent = background;
            cavet3.BackColor = Color.Transparent;
            arrowt1.Parent = background;
            arrowt1.BackColor = Color.Transparent;
            arrowt2.Parent = background;
            arrowt2.BackColor = Color.Transparent;
            arrowt3.Parent = background;
            arrowt3.BackColor = Color.Transparent;
            label1.Parent = background;
            label1.BackColor = Color.Transparent;
            label1.Visible = false;
            shark.Parent = background;
            shark.BackColor = Color.Transparent;
            shark.Visible = false;
            bats.Visible = false;
        }

        /*
        public void UpdateGraphics(int cave1num, int cave2, int cave3, Boolean batsShow, Boolean pitShow, Boolean wumpusShow)
        {
            /*
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
            }*/
        //}

        private void buyArrows_Click(object sender, EventArgs e)
        {
            bool money = gc.buyArrows();
            if (!money)
            {
                int s = gc.getPlayerInfo().getGold();
                MessageBox.Show("Not enough money: " + s);
            }
            update();

        }

        private void score_Click(object sender, EventArgs e)
        {
        }

        private void gold_Click(object sender, EventArgs e)
        {
        }

        private void CurrentRoomNum_Click(object sender, EventArgs e)
        {
            CurrentRoomNum.Text = Convert.ToString(gc.getMap().getPlayerPosition());
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void arrowCount_Click(object sender, EventArgs e)
        {

        }

        private void cavet1_Click(object sender, EventArgs e)
        {
            gc.getMap().movePlayer(surroundingRoom[0]);
            gc.getPlayerInfo().addScore(20);
            int x = rand.Next(1, 5);
            if (x == 3)
            {
                gc.getPlayerInfo().addGold(100);
            }
            update();
        }

        private void cavet2_Click(object sender, EventArgs e)
        {
            gc.getMap().movePlayer(surroundingRoom[1]);
            gc.getPlayerInfo().addScore(20);
            int x = rand.Next(1, 5);
            if (x == 3)
            {
                gc.getPlayerInfo().addGold(100);
            }
            update();
        }

        private void cavet3_Click(object sender, EventArgs e)
        {
            gc.getMap().movePlayer(surroundingRoom[2]);
            gc.getPlayerInfo().addScore(20);
            int x = rand.Next(1, 5);
            if (x == 3)
            {
                gc.getPlayerInfo().addGold(100);
            }
            update();
        }

        private void arrowt1_Click(object sender, EventArgs e)
        {
            if (gc.getPlayerInfo().getArrows() != 0)
            {
                gc.getPlayerInfo().removeArrows();
                if ((surroundingRoom[0] == gc.getMap().getWumpusPosition()))
                {
                    var winMessage = MessageBox.Show("YOU WON <3");
                    TitleScreen form = new TitleScreen();
                    gc.getHighScore().addHighScore(gc.getPlayerInfo().getScore());
                    form.Show();
                    form.Activate();
                    this.Hide();

                }

            }
            else if (gc.getPlayerInfo().getArrows() == 0)
            {
                var message = MessageBox.Show("You do not have any arrows");
            }
            update();
        }

        private void arrowt2_Click(object sender, EventArgs e)
        {
            if (gc.getPlayerInfo().getArrows() != 0)
            {
                gc.getPlayerInfo().removeArrows();
                if (surroundingRoom[1] == gc.getMap().getWumpusPosition())
                {
                    var winMessage = MessageBox.Show("YOU WON <3");
                    TitleScreen form = new TitleScreen();
                    gc.getHighScore().addHighScore(gc.getPlayerInfo().getScore());
                    form.Show();
                    form.Activate();
                    this.Hide();

                }
            }
            else if(gc.getPlayerInfo().getArrows() == 0)
            {
                var message = MessageBox.Show("You do not have any arrows");
            }
            update();
        }

        private void arrowt3_Click(object sender, EventArgs e)
        {
            if (gc.getPlayerInfo().getArrows() != 0)
            {
                gc.getPlayerInfo().removeArrows();
                if (surroundingRoom[2] == gc.getMap().getWumpusPosition())
                {
                    var winMessage = MessageBox.Show("YOU WON <3");
                    TitleScreen form = new TitleScreen();
                    gc.getHighScore().addHighScore(gc.getPlayerInfo().getScore());
                    form.Show();
                    form.Activate();
                    this.Hide();

                }
            }
            else if (gc.getPlayerInfo().getArrows() == 0)
            {
                var message = MessageBox.Show("You do not have any arrows");
            }
            update();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bats_Click(object sender, EventArgs e)
        {

        }




    }
}
