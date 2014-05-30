using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WumpusTest
{
    class Wumpus
    {
        //I WANT YOU NOT TO WORRY ABOUT MOVING THE WUMPUS BUT
        //ALLOWING OTHERS TO KNOW WHEN WUMPUS IS ALLOWED TO MOVE
        private Sound _Sound; //GC WILL MAKE SOUNDS FOR YOU
        public enum WumpusState { asleep, awake, moving };
        public WumpusState State { get; set; } //why do we need this?

        private Random random = new Random();
       
        private int subdivisionTurn = 0;
       // private Map loc = new Map();

        public Wumpus()
        {
            State = WumpusState.asleep;
           // State = WumpusState.awake;
           // State = WumpusState.moving;
          //  loc.movePlayer(random.Next(50));
        }
        /* MADE IN G.C
        private void move() 
        {
            int[] room = loc.getConnectedRooms(loc.getPosition());
            int choose = random.Next(0, room.Length);
            loc.movePlayer(choose);
        }
        */

        public enum WumpusMove {MoveOne, MoveTwo, Teleport, DontMove }
        public WumpusMove howWumpusWillMove()
        {  
            subdivisionTurn++;
            if (random.Next(100) < 5)
            {
                State = WumpusState.awake;
                subdivisionTurn = 0;
                return WumpusMove.Teleport;
            }
            else if (subdivisionTurn >= 5 && subdivisionTurn < 10)
            {
                State = WumpusState.awake;
                if (random.Next(50) < 10)
                {
                    subdivisionTurn = 0;
                    int x = random.Next(3);
                    if (x == 0){
                        return WumpusMove.DontMove;
                    }
                    if (x == 1) {
                        return WumpusMove.MoveOne;
                    }
                    if (x == 2) {
                        return WumpusMove.MoveTwo;
                    }

                    
                }

                State = WumpusState.asleep;
            }

            else if (subdivisionTurn == 10)
            {
                State = WumpusState.awake;
                if (random.Next(50) < 10)
                {
                    subdivisionTurn = 0;
                    int x = random.Next(3);
                    if (x == 0)
                    {
                        return WumpusMove.DontMove;
                    }
                    if (x == 1)
                    {
                        return WumpusMove.MoveOne;
                    }
                    if (x == 2)
                    {
                        return WumpusMove.MoveTwo;
                    }


                }

                State = WumpusState.asleep;
            }

            //Trivia will be taken care of GC. Remind GameControl
            return WumpusMove.DontMove;
        }

        // turn : turn++ when user asks if the wumpus should move. Enum of Active wumpus and lazy wumpus.
      
    }
}
