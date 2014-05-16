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
            private Player player = new Player();
            private Map map = new Map();
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

            public GameState getTotalAfterBought()
            {
                player.addArrows();
                return updateGameState();
            }

            private GameState updateGameState()
            {
                return new GameState(player, map);
            }
        }
    }


}
