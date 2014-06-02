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
            pos = pictureBox4.PointToClient(pos);
            arrowCount.Parent = pictureBox4;
            arrowCount.Location = pos;
            arrowCount.BackColor = Color.Transparent;
            
            var pos2 = this.PointToScreen(gold.Location);
            pos2 = pictureBox4.PointToClient(pos2);
            gold.Parent = pictureBox4;
            gold.Location = pos2;
            gold.BackColor = Color.Transparent;
            
            var pos3 = this.PointToScreen(score.Location);
            pos3 = pictureBox4.PointToClient(pos3);
            score.Parent = pictureBox4;
            score.Location = pos3;
            score.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(CurrentRoomNum.Location);
            pos4 = pictureBox4.PointToClient(pos4);
            CurrentRoomNum.Parent = pictureBox4;
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

            cave1.Text = cave1Int.ToString();
            cave2.Text = cave2Int.ToString();
            cave3.Text = cave3Int.ToString();
            score.Text = "score: " + scoreVal.ToString();
            gold.Text = "gold: " + goldVal.ToString();
            arrowCount.Text = "arrows: " + arrowVal.ToString();
            const String shootT = "shoot at: ";
            shoot1.Text = shootT + cave1Int.ToString();
            shoot2.Text = shootT + cave2Int.ToString();
            shoot3.Text = shootT + cave3Int.ToString();
            CurrentRoomNum.Text = "Current Room: " + currentRoom;

            Console.WriteLine("pit: " + printArray(gc.getMap().getPitPosition()));
            Console.WriteLine("bat: " + printArray(gc.getMap().getBatPosition()));
            Console.WriteLine("wumpus: " + gc.getMap().getWumpusPosition().ToString());
            Console.WriteLine("player: " + gc.getMap().getPlayerPosition().ToString());

            if(gc.getMap().isWumpusWithPlayer())
            {
                var message = MessageBox.Show("YOU ARE WITH THE invisible WUMPUS...OH NO D:");

                
                TriviaForm1 trivia = new TriviaForm1();
                trivia.ShowDialog();
                bool wonTrivia = trivia.WonGame;
                
                //TODO: implement a way to pop up trivia.
            }
            if(gc.getMap().isPitWithPlayer())
            {
                var message = MessageBox.Show("ouchie..you died in the invisible PIT :(");
            }
            if(gc.getMap().isBatWithPlayer())
            {
                var message = MessageBox.Show("watch out..there are invisible bats.");
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
            update();

        }

        private void cave2_Click(object sender, EventArgs e)
        {
            //gc.move(Convert.ToInt32(cave2.Text));
            //gc.move(surroundingRoom[0]);
            gc.getMap().movePlayer(surroundingRoom[1]);
            gc.getPlayerInfo().addScore(20);
            update();
        }

        private void cave3_Click(object sender, EventArgs e)
        {
            //gc.move(Convert.ToInt32(cave3.Text));
            ///gc.move(surroundingRoom[1]);
            gc.getMap().movePlayer(surroundingRoom[2]);
            gc.getPlayerInfo().addScore(20);
            update();
        }

        private void cave1_Click_1(object sender, EventArgs e)
        {
            //gc.move(Convert.ToInt32(cave1.Text));
            //gc.move(surroundingRoom[2]);
            gc.getMap().movePlayer(surroundingRoom[0]);
            gc.getPlayerInfo().addScore(20);
            update();
        }

        private void score_Click(object sender, EventArgs e)
        {
            //score.Text = "Score" + Convert.ToString(gc.getPlayerInfo().getScore());
        }

        private void gold_Click(object sender, EventArgs e)
        {
            //gold.Text = "Gold" + Convert.ToString(gc.getPlayerInfo().getGold());

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void shoot1_Click(object sender, EventArgs e)
        {
            if(gc.getPlayerInfo().getArrows() != 0)
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
            update();
        }

        private void shoot2_Click(object sender, EventArgs e)
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
            update();
        }

        private void shoot3_Click(object sender, EventArgs e)
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
            update();
        }



    }
}
