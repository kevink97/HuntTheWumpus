using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{

    class Score : IComparable
    {
        private String name;
        private int score;
        public Score(String name, int score)
        {
            this.name = name;
            this.score = score;
        }
        public String getName()
        {
            return name;
        }
        public int getScore()
        {
            return score;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setScore(int score)
        {
            this.score = score;
        }
        int IComparable.CompareTo(object obj)
        {
            Score c = (Score)obj;
            if (this.score > c.score)
            {
                return -1;
            }
            else if (this.score == c.score)
            {
                return 0;
            }
            else { return 1; }

        }
        public String showString()
        {
            return name + ", " + score;
        }

        public String getScoreForList()
        {
            return name + " - " + score;
        }

    }       
}
