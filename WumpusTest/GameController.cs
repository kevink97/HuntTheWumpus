using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{
    //TODO: ADD VAISNHAVI'S CODE
    class GameController
    {

        class GameState
        {
            public static readonly int MENU = 1;
            public static readonly int GAME = 2;
            public static readonly int END = 3;
            
            private int currentState = 1;

            /// <summary>
            /// Updating Changes Current State of Game  (1 = MENU | 2 = GAME | 3 = END)
            /// </summary>
            /// <param name="currentState">int of set currentState</param>
            public void changeCurrentState(int currentState)
            {
                this.currentState = currentState;
            }

            /// <summary>
            /// Gets what part of the game it is on (1 = MENU | 2 = GAME | 3 = END)
            /// </summary>
            /// <returns>the integer value of Game State. </returns>
            public int getCurrentState()
            {
                return currentState;
            }
        } 
        private Player player = new Player();
        private Wumpus wumpus = new Wumpus();
        private Map map = new Map();
        private Sound sound = new Sound();
        private HighScore hs = new HighScore();
        private static GameState gs = new GameState();
        private Random random = new Random();
        private int caveNumber = 0; //TODO: implement caveNumber random generator

        /// <summary>
        /// Use this method to declare that the game is starting to keep track of GameState.
        /// It sets CurrentState to GAME
        /// Sets both Player and the Wumpus's Position.
        /// Plays continuous background noise.
        /// Sets all player value to Default Value
        /// </summary>
        public void newGame()
        {
            int randomCaveNumber = random.Next(5);
            caveNumber = randomCaveNumber;
            if(randomCaveNumber == 0)
            {
                map.GenerateCave();

            }
            else if(randomCaveNumber == 1)
            {
                map.GenerateCave2();
            }
            else if(randomCaveNumber == 2)
            {
                map.GenerateCave3();
            }
            else if(randomCaveNumber == 3)
            {
                map.GenerateCave4();
            }
            else
            {
                map.GenerateCave5();
            }
            map.generateRandomPlayerPosition();
            map.generateRandomWumpusPosition();
            //sound.playBackgroundMusic(Continuous.background);
            player.initializeAllValueToStandard();
        }

        /// <summary>
        /// Gets latest Map Data. Cond: CurrentState is GAME
        /// Note: Graphics...call only necessary data as listed.
        /// getConnectedRooms(int room), getPlayerPosition().
        /// </summary>
        /// <returns>Map Data if GameState is GAME</returns>
        public Map getMap()
        {
            return map;
        }
            
        /// <summary>
        /// Gets Player Object created in GameController class.
        /// </summary>
        /// <returns>if CurrentState of game is GameState.MENU or GameState.GAME, it will return player.
        /// Other wise, it will return null to prohibit bad calls.</returns>
        public Player getPlayerInfo()
        {
            return player;
        }

        /// <summary>
        /// This is the main moving method for the player.
        /// Every movement of player needs to call this method. 
        /// It runs sound as well based on location of wumpus.
        /// </summary>
        /// <param name="cellNumber">Cell Number is required to be a connected room of the player's.</param>
        public void move(int cellNumber)
        {/*
            player.addTurn();
            wumpus.addTurn();
            map.movePlayer(cellNumber);
            int[] room = map.getConnectedRooms(map.getWumpusPosition(), caveNumber);
            int randomInt = random.Next(0, room.Length);
            map.moveWumpus(randomInt);
            if (map.getWumpusPosition() == map.getPlayerPosition())
            {
                sound.playBackgroundMusic(Continuous.carnivalBackground);
            }
            else if (map.isWumpusNear())
            {
                sound.playSound(soundEffects.wumpusClown);
            }

            else if (map.areBatsNear())
            {
                sound.playSound(soundEffects.bats);
            }*/
        }

        /// <summary>
        /// Use this method to buy arrows. Each arrows cost 20 gold.
        /// </summary>
        /// <returns>returns true if gold stays above or equal to 0 | returns false if gold does go below 0</returns>
        public Boolean buyArrows()
        {
            if(player.getGold() - 20 >= 0)
            {
                player.removeGold(20);
                player.addArrows();
                return true;
            }
            return false;
        }

        /// <summary>
        /// use this method when shooting arrow.
        /// </summary>
        /// <param name="cellNumber">the cell number the arrow is being shot at</param>
        /// <returns>true if shot at wumpus location. false if not shot at wumpus location</returns>
        public bool shootArrow(int cellNumber)
        {
            if(map.getWumpusPosition() == cellNumber)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// only for GameController's reference for ease of programming
        /// </summary>
        /// <param name="cellNumber">cell number of the place player wants to go</param>
        /// <returns>if the connected room matches cell number it returns true. Otherwise, false.</returns>
        private Boolean isConnectedRoomsForPlayer(int cellNumber)
        {
            int[] room = map.getConnectedRooms(map.getPlayerPosition(), caveNumber);
            for(int i = 0; i < room.Length; i++)
            {
                if(room[i] == cellNumber)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
