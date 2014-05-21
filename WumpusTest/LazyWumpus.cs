using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTester
{
    class LazyWumpus
    {
         private Sound _sound;
        public enum WumpusState { asleep, awake, moving };
        public WumpusState State{ get; set;}
       
        public enum numTurnsLazyWump { noMove, moveOnce, moveTwice, randomMove}; 
        public numTurnsLazyWump numTurns{get; set;}

        private Random random = new Random();
        private int turns;
        private Map  loc = new Map();
  
        public LazyWumpus() 
        {
            State = WumpusState.asleep;
            State = WumpusState.awake;
            State = WumpusState.moving;
            loc.movePlayer(random.Next(50));
        }

        private void move() 
        {
            int[] room = loc.getConnectedRooms(loc.getPosition());
            int choose = random.Next(0, room.Length);
            loc.movePlayer(choose);
        }


        //own sound effects/trivia
        public void playSound()
        {
            if (loc.isWumpusNear())
            {
                _sound.playSound(soundEffects.wumpusClown);
                move();
            }

            else
            {
               // different sound
                _sound.playSound(soundEffects.wumpusClown); 
            }

        }

        //turn : turn++ when user asks if the wumpus should move. Enum of Active wumpus and lazy wumpus.
        public void numTurnsLazyWumpus() {
            turns++;

            if (){
                State = WumpusState.awake;
                //Game control: runs up to two rooms away from current position.
            }

            }
            }

        
        }

