using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{
   public interface IMap
    {
        void GenerateCave();

        void GenerateCave2();

        void GenerateCave3();

        void GenerateCave4();

        void GenerateCave5();

        void movePlayer(int cellnumber);

        bool isWumpusNear();

        bool areBatsNear();

        bool isPitNear();

        void generateRandomPosition();

        int[] getConnectedRooms(int room);

        bool isPositionHazardous();

        int getPlayerPosition();

        int getPitPosition();

        int getWumpusPosition();

        void moveWumpus();

        void generateRandomWumpusPosition();

        void generateRandomPlayerPosition();

        void generatePit();

        void generateBats(); 

   }
}
