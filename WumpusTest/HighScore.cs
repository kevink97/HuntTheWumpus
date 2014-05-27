using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WumpusTest
{
    class HighScore
    {
        List<Score> listofscores = new List<Score>();
        Score[] list = new Score[10]; // 0 (highest) -> 9 (lowest)

        //when game starts, high score will be initiated with past high scores from .txt file. 
        public HighScore()
        {/*read in list of high scores from file, save to list of scores*/
          listofscores.Add(new Score("Fred", 100)); listofscores.Add(new Score("Sarah", 200)); listofscores.Add(new Score("Anna", 320)); listofscores.Add(new Score("Rose", 220)); listofscores.Add(new Score("Hannah", 180)); listofscores.Add(new Score("Emma", 324)); listofscores.Add(new Score("Kyle", 134)); 
          listofscores.Sort();
          
          String line = ""; //parse the result into an array of Score and store it in the Score[] list already initiated as a member varaible.
          try //I dunno if this works either
          {
              using (StreamReader sr = new StreamReader("HighScoreList.txt"))
              {
                  line = sr.ReadToEnd();
                  Console.WriteLine(line);
              }
          }
          catch (Exception e)
          {
              Console.WriteLine("The file could not be read:");
              Console.WriteLine(e.Message);
          }


        }

        public void updateHighScoreInFile()
        {
            String update = "";
            for(int i = 0; i < list.Length; i++)
            {
                if(list[i] != null)
                {
                    update += list[i].getName() + "-" + list[i].getScore() + "|";
                }
                else
                {
                    update += "none-0|";
                }
            }
            File.WriteAllText("HighScoreList.txt", update); //CHECK IF THIS WORKS...CUZ I DUNNO
        }
       
        /// <summary>
        /// adds highscore into list.
        /// if score is not high enough, it will not add.
        /// </summary>
        /// <param name="name">name of the player</param>
        /// <param name="score">score earned by the player</param>
        public void addHighScore(String name , int score)
        {
            //create new score object with score name
            Score newscore = new Score(name, score);
            bool isHighScore = isHighScoreChecker(newscore);
            if(isHighScore)
            {
                for(int i = list.Length - 1; i >= 0; i--)
                {
                    if(list[i].getScore() <= newscore.getScore())
                    {
                        Score[] tempAr = list;
                        for(int x = i + 1; x < list.Length; x++)
                        {
                            list[x] = tempAr[x-1];
                        }
                        list[i] = newscore;
                    }
                }
            }

            listofscores.Add(newscore);
            listofscores.Sort();


           
        }

        /// <summary>
        /// Checks if the new Score is a high score
        /// </summary>
        /// <param name="score">score that is to be compared to with all the other score</param>
        /// <returns></returns>
        private bool isHighScoreChecker(Score score)
        {
            for(int i = 0; i < list.Length; i++)
            {
                if(list[i].getScore() < score.getScore())
                {
                    return true;
                }
            }
            return false;
        }
       
        /* DELETED. new implementation in GC
      // Figure out the form/message box situation 
        private void DisplayMessageBoxText()
        {
            MessageBox.Show("High Score" + listofscores);
        }
         * */
        public void saveScores()
               {
            List <String> newscore = new List <String>();
           // saves score to file
           String temp = " ";
            for (int i =0; i<10; i++){

             temp = (getName(listofscores) + "*" + getScore(listofscores));
             newscore.Add(temp); 

            }
            System.IO.File.WriteAllLines(@"TextFile1.txt", newscore);


        }

        private string getScore(List<Score> listofscores)
        {
            throw new NotImplementedException();
        }

        private string getName(List<Score> listofscores)
        {
            throw new NotImplementedException();
        }
      
    }
    
}