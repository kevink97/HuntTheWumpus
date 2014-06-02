using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WumpusTest
{
    public class Player : IPlayer
    {
        private int turns;
        private int gold;
        private int arrows;
        private int score;

        public void initializeAllValueToStandard()
        {
            turns = 0;
            gold = 50;
            arrows = 0;
            score = 0;
        }

        public void addScore(int addedScore)
        {
            score += addedScore;
        }
         
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
