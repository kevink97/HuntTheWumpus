using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTester
{   
    class Wumpus
    {
        private Sound _sound;
        public enum WumpusState { asleep, awake };
        public WumpusState State{ get; set;}
       
        public enum numTurnsActiveWump { noMove, moveOnce, moveTwice, randomMove}; 
        public numTurnsActiveWump numTurns{get; set;}

       // private Location loc = new Location();
       // generate random location when it starts
        public Wumpus()//loc)
        {
            State = WumpusState.asleep;
            State = WumpusState.awake;

            //this.loc = loc;
            //generate random location
        }

        // yes or no move, far or near
        // own sound effects/trivia
        public void playSound()
        {

            //talk to game control, if wumpus is nearby, play a sound
            if (loc.nearPlayer())
            {
                _sound.playSound(soundEffects.wumpus);
                //move
            }

            if (loc.farPlayer())
            {
                _sound.playSound(soundEffects.wumpus); 
                //no move
            }

        }

        public void numTurns() {
           
           }

        }



        //•	Keep track of the current state the Wumpus is in (*that is, asleep and awake).
        //•	Keep track of the number of turns.
        //•	Every 5 to 10 turns the Wumpus will wake up and move 1 room per turn for up to three turns
        //  before going back to sleep.

     // turn : turn++ when user asks if the wumpus should move. Enum of Active wumpus and lazy wumpus.



  

    }
}
