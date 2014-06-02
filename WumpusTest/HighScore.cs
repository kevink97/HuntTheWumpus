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
        public static Score[] list = {new Score("Player1", 700), new Score("Player2", 0),
                           new Score("Player3", 0),
                           new Score("Player4", 0),
                           new Score("Player5", 0),
                           new Score("Player6", 0),
                           new Score("Player7", 0),
                           new Score("Player8", 0),
                           new Score("Player9", 0),
                           new Score("Player10", 0)};//new Score[10]; // 0 (highest) -> 9 (lowest)

        //when game starts, high score will be initiated with past high scores from .txt file. 
        public HighScore()
        {/*read in list of high scores from file, save to list of scores*/
          //listofscores.Add(new Score("Fred", 100)); listofscores.Add(new Score("Sarah", 200)); listofscores.Add(new Score("Anna", 320)); listofscores.Add(new Score("Rose", 220)); listofscores.Add(new Score("Hannah", 180)); listofscores.Add(new Score("Emma", 324)); listofscores.Add(new Score("Kyle", 134)); 
          //listofscores.Sort();
            
                      // NEED TO SORT THE ARRAY
            //UPDATE HIGH SCORE --> END OF GAME
            //CHECK UPDATE HIGH SCORE
            // 
          //String line = ""; //parse the result into an array of Score and store it in the Score[] list already initiated as a member varaible.
          /*try //I dunno if this works either
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
           */
            /* KEEP THIS AGAIN
          string path = @"HighScoreList.txt";

          String[] lines = System.IO.File.ReadAllLines(path);
          System.Console.WriteLine("Contents of HighScoreList.txt = ");
          for (int i = 0; i < lines.Length; i++)
          {
              string temp = lines[i];
              char delimiter = ',';
              string[] words = temp.Split(delimiter);
              String name = words[0];
              int score = Convert.ToInt32(words[1]);
              list[i] = new Score(name, score);

          }*/
            // write a sort method and call after reading in scores from a file
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
            Score index;
            int j;
            if (isHighScoreChecker(newscore))
            {
                list[list.Length - 1] = newscore;
                for (int i = 1; i < list.Length; i++)
                {
                    index = list[i];
                    j = i;
                    while ((j > 0) && (list[j - 1].getScore() > index.getScore()))
                    {
                        list[j] = list[j - 1];
                        j = j - 1;
                    }
                    list[j] = index;
                }

            }
            updateHighScoreInFile();
           
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