using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WumpusTest
{
    public class Player : IPlayer
    {

        //JUST A NOTE..YOU SHOULD ADD INITIAL GOLD AND ARROWS TO MAKE SURE THIS GAME IS PLAYABLE
        private int turns;
        private int gold;
        private int arrows;
        private int score;
         
        public void addTurn()
        {
            turns++;
        }

        public void addGold(int add)
        {
            gold = gold + add; 
        }

        public int getScore()
        {
            return score;
        }


        public void computeScore()
        {
            score = gold + arrows;
        }


        public void removeGold(int subtractGold)
        {
            gold = gold - subtractGold; 
        }


        public void addArrows()
        {
            arrows++;
        }


        public void removeArrows()
        {
            arrows--; 
        }

        public int getGold()
        {
            return gold;
        }

        public int getTurns()
        {
            return turns; 
        }

        public int getArrows()
        {
            return arrows; 
        }

    }
}
