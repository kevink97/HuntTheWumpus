using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{
    public interface IPlayer
    {
        void initializeAllValueToStandard();

        void addTurn();

        void addGold(int add);

        int getScore();

        void computeScore();

        void removeGold(int subtractGold);

        void addArrows();

        void removeArrows();

        int getGold();

        int getTurns();

        int getArrows();
    }
}
