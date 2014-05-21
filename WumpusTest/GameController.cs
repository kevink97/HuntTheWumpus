using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//make non of the static. you can get all counts from the Player class
//ONLY GETTERS....i.e. getSorroundingCavew
namespace WumpusTest
{
    class GameController
    {
        class GameState
        {
            public static readonly int MENU = 1;
            public static readonly int GAME = 2;
            public static readonly int END = 3;
            
            private int currentState = 1;

            /// <summary>
            /// Updating Changes Current State of Game
            /// </summary>
            /// <param name="currentState">1 = MENU | 2 = GAME | 3 = END</param>
            public void changeCurrentState(int currentState)
            {
                this.currentState = currentState;
            }

            /// <summary>
            /// Gets what part of the game it is on (MENU/GAME/END)
            /// </summary>
            /// <returns>the integer value of Game State. (1 = MENU | 2 = GAME | 3 = END)</returns>
            public int getCurrentState()
            {
                return currentState;
            }
        }
        private Player player = new Player();
        private Map map = new Map();
        GameState gs = new GameState();

        /// <summary>
        /// Use this method to declare that the game is starting to keep track of GameState.
        /// </summary>
        public void newGame()
        {
            gs.changeCurrentState(1);
            map.Generate();
            map.generateRandomPlayerPosition();
            map.generateRandomWumpusPosition();
        }

        /// <summary>
        /// Gets latest Map Data. 
        /// Note: Graphics...call only necessary data as listed.
        /// getConnectedRooms(int room), getPosition(), 
        /// </summary>
        /// <returns>Map Data</returns>
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
            if((gs.getCurrentState() == GameState.MENU) || (gs.getCurrentState() == GameState.GAME))
            {
                return player;
            }
            else return null;
        }

        public void move(int cellNumber)
        {
            map.movePlayer(cellNumber);
        }

        }
    }


}
