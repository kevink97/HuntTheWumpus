using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

// 1. test if the new code in constructor works
// 2. if it does work... covert the string from file to array.
// 3. check if void updateHighScoreInFile() works.
// 4. check public void addHighScore(String name , int score) and private bool isHighScoreChecker(Score score)
namespace WumpusTest
{
    class HighScore
    {
       // List<Score> listofscores = new List<Score>();
        public static String name;
        public static Score[] list = {new Score("---", 0),
                           new Score("---", 0),
                           new Score("---", 0),
                           new Score("---", 0),
                           new Score("---", 0),
                           new Score("---", 0),
                           new Score("---", 0),
                           new Score("---", 0),
                           new Score("---", 0), new Score("---", 0)};//new Score[10]; // 0 (highest) -> 9 (lowest)

        //when game starts, high score will be initiated with past high scores from .txt file. 
        public HighScore()
        {
        }

        public void updateHighScoreInFile()
        {
            String update = "";
            for(int i = 0; i < list.Length; i++)
            {
                if(list[i] != null)
                {
                    update += list[i].getName() + "," + list[i].getScore() + System.Environment.NewLine;
                }
                else
                {
                    update += "none,0";
                }
            }
            //string path2 = @"HighScoreList.txt";
            TextWriter tw = new StreamWriter(@"HighSchoolList.txt");

            // write a line of text to the file
            tw.WriteLine(DateTime.Now);

            // close the stream
            tw.Close();
            //File.AppendAllText(path2, update); //CHECK IF THIS WORKS...CUZ I DUNNO
        }

        public static String displayHighScore()
        {
            
            String test = "";
            for (int i = list.Length - 1; i >= 0; i--)
            {
                test += list[i].showString() + System.Environment.NewLine;
            }
            return test;
        }
        

        /// <summary>
        /// adds highscore into list.
        /// if score is not high enough, it will not add.
        /// </summary>
        /// <param name="name">name of the player</param>
        /// <param name="score">score earned by the player</param>
        public void addHighScore(int score)
        {
            //create new score object with score name
            Score newscore = new Score(name, score);
            //Score index;
            //int j; 
            if (isHighScoreChecker(newscore) != -1)
            {
                for(int i = 1; i <= isHighScoreChecker(newscore); i++)
                {
                    list[i-1] = list[i];
                }
                list[isHighScoreChecker(newscore)] = newscore;
            }
            updateHighScoreInFile();
           
        }

        /// <summary>
        /// Checks if the new Score is a high score
        /// </summary>
        /// <param name="score">score that is to be compared to with all the other score</param>
        /// <returns></returns>
        private int isHighScoreChecker(Score score)
        {
            for(int i = list.Length - 1; i >= 0; i--)
            {
                if(list[i].getScore() < score.getScore())
                {
                    return i;
                }
            }
            return -1;
        }
       
        /* DELETED. new implementation in GC
      // Figure out the form/message box situation 
        private void DisplayMessageBoxText()
        {
            MessageBox.Show("High Score" + listofscores);
        }
         * */
        //change the savescore to an array
       /* public void saveScores()
               {
            List <String> newscore = new List <String>();
           // saves score to file
           String temp = " ";
            for (int i =0; i<10; i++){

             temp = (getName(list) + "*" + getScore(list));
             newscore.Add(temp); 

            }
            System.IO.File.WriteAllLines(@"TextFile1.txt", newscore);


        }
        * 

        private string getScore(List<Score> listofscores)
        {
            throw new NotImplementedException();
        }

        private string getName(List<Score> listofscores)
        {
            throw new NotImplementedException();
        }
        * */
      
    }
    
}