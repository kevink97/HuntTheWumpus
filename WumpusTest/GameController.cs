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
        private Player player = new Player();
        private Map map = new Map();
        class GameState
        {
            public GameState(Player player, Map map)
            {

            }

            public GameState newGame()
            {
                return null;

            }


            public GameState move(Map loc)
            {
                return updateGameState();
            }

            public static GameState buyAnArrow()
            {
                arrows++;
                return updateGameState();
            }

            private static GameState updateGameState()
            {
                return new GameState(arrows, score, loc);
            }
        }
    }


}
