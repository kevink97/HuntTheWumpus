using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WumpusTrivia
{
    class Trivia1
    {
        private int[][] square;
        private String difficulty;

        Random rc = new Random();

        public Boolean startTrivia()
        { return true; }

        public String getDifficulty()
        { return difficulty; }

        public Trivia1()//String difficulty)
        {
            //if (difficulty.Equals("normal"))
            //{
            //TriviaForm1 easy = new TriviaForm1();
            //easy.Show();
            //}
                /*
            else if (difficulty.Equals("hard"))
            {
            TriviaForm2 normal = new TriviaForm2();
            normal.Show();
            }*/
        }
        public Boolean endTrivia()
        { return false; }
        
        
}

    }
