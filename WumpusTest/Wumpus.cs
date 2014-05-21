using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Random;
namespace WumpusTest
{   
    class Wumpus
    {
        private Sound _sound;
        public enum WumpusState { asleep, awake, moving };
        public WumpusState State{ get; set;}
       
        public enum numTurnsActiveWump { noMove, moveOnce, moveTwice, randomMove}; 
        public numTurnsActiveWump numTurns{get; set;}

        private Random random = new Random();
        private int turns;
        private Map  loc = new Map();
  
        public Wumpus() 
        {
            State = WumpusState.asleep;
            State = WumpusState.awake;
            State = WumpusState.moving;
            loc.movePlayer(random.Next(50));
        }
        /* MADE IN G.C
        private void move() 
        {
            int[] room = loc.getConnectedRooms(loc.getPosition());
            int choose = random.Next(0, room.Length);
            loc.movePlayer(choose);
        }
        */

        //own sound effects/trivia
        public void playSound()
        {
            if (loc.isWumpusNear())
            {
                _sound.playSound(soundEffects.wumpusClown);
                //move();
            }

            else
            {
               // different sound
                _sound.playSound(soundEffects.wumpusClown); 
            }

        }

        //ADDED FOR CONVENIENCE
        public void addTurn()
        {
            turns++;
        }

         // turn : turn++ when user asks if the wumpus should move. Enum of Active wumpus and lazy wumpus.
        public void numTurnsActiveWumpus() { 
            turns++;

            if (turns >= 5 && turns <=10){
               State = WumpusState.awake;
               //Game control: move 1 room per turn for up to three turns
            }

            int chance;
            chance = random.Next(20);

            if (chance == 5){
                 int[] room = loc.getConnectedRooms(loc.getPosition());
                 int choose = room[random.Next(0, room.Length)];
                 loc.movePlayer(choose);
            }
            
            }
        }
        }
        //•	Keep track of the current state the Wumpus is in (*that is, asleep and awake).
        //•	Keep track of the number of turns.
        //•	Every 5 to 10 turns the Wumpus will wake up and move 1 room per turn for up to three turns
        //  before going back to sleep.
        //•	Every turn, there is a 5% chance the Wumpus will immediatelyteleport to a new, random location.

