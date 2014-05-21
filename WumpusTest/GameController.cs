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
        enum GameState { MENU, GAME, END}
        private Player player = new Player();
        private Map map = new Map();
        private int currentGameState;

        public void newGame()
        {
            currentGameState = (int)GameState.GAME;
            getMap();
            getPlayerInfo();
        }

        private Map getMap()
        {
            return map;
        }

        private Player getPlayerInfo()
        {
            if((currentGameState == (int)GameState.GAME) || (currentGameState == (int)GameState.END))
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
