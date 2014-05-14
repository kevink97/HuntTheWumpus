using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{
   public interface IMap
    {
        void Generate();

        void movePlayer(int cellnumber);

        bool isWumpusNear();

        bool areBatsNear();

        bool isPitNear();

        int getStartPosition();

        void generateRandomPosition();

        int[] getConnectedRooms(int room);

        bool isPositionHazardous();

        int getPosition();

        int getPitPosition();

        int getWumpusPosition(); 
   }
}
