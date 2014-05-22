using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class HighScore
    {

        Score[] listofscores;
        public HighScore()
        {/*read in list of high scores from file, save to list of scores*/
            listofscores = new Score[]{
               new Score("Fred", 100), new Score("Sarah", 200), new Score ("Anna", 320), new Score("Rose", 220), new Score("Hannah", 180), new Score("Emma", 324), new Score("Kyle", 134), new Score("Paulette", 325), new Score("Pilar", 443), new Score("Alejandro", 225)
           };
            Array.Sort(listofscores);
        }

        public Score[] getHighScore()
        {
            return listofscores;
        }
        public void addHighScore(int score, String name)
        {
            //create new score object with score name
            Score newscore = new Score(name, score);
            //add that to list of scores
            int length = listofscores.Length;

            if (newscore.getScore() < listofscores[length].getScore())
            {
                if (length == 10)
                {
                    return;
                }
                else { listofscores[length + 1] = newscore; }
            }
            else if (newscore.getScore() > listofscores[0].getScore())
            {
                for (int i = 0; i < 9; i++)
                {
                    listofscores[i + 1] = listofscores[i];
                }
                listofscores[0] = newscore;

                //sort list
            }
        }

        public void saveScores()
        {
            //save list of scores out to file
        }
        public String showString()
        {
            String test = "";
            for (int i = 0; i < listofscores.Length; i++)
            {
                test += listofscores[i].showString() + " ";
            }
            return test;
        }
    }
}