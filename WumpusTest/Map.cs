using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{
    public class Map : IMap
    {
        
        int playerPosition;
        const int mapSize = 30;
        int batPosition;
        int pitPosition;
        int wumpusPosition;
        //added private member variable caveNumber to specify which cave when getting connected rooms
        int caveNumber; 
        //added new private member variable Random to ensure randomness
        private Random random = new Random();
        Dictionary<int, int[]> cave = new Dictionary<int, int[]>();
        Dictionary<int, int[]> cave2 = new Dictionary<int, int[]>();
        Dictionary<int, int[]> cave3 = new Dictionary<int, int[]>();
        Dictionary<int, int[]> cave4 = new Dictionary<int, int[]>();
        Dictionary<int, int[]> cave5 = new Dictionary<int, int[]>();
        
        
        public void GenerateCave()
        {
            cave.Add(1, new int[] { 30, 2, 7 });
            cave.Add(2, new int[] { 1, 3, 8 });
            cave.Add(3, new int[] { 2, 4, 9 });
            cave.Add(4, new int[] { 3, 5, 10 });
            cave.Add(5, new int[] { 4, 6, 11 });
            cave.Add(6, new int[] { 5, 7, 12 });
            cave.Add(7, new int[] { 6, 8, 13 });
            cave.Add(8, new int[] { 7, 9, 14 });
            cave.Add(9, new int[] { 8, 10, 15 });
            cave.Add(10, new int[] { 9, 11, 16 });
            cave.Add(11, new int[] { 10, 12, 17 });
            cave.Add(12, new int[] { 11, 13, 18 });
            cave.Add(13, new int[] { 12, 14, 19 });
            cave.Add(14, new int[] { 13, 15, 20 });
            cave.Add(15, new int[] { 14, 16, 21 });
            cave.Add(16, new int[] { 15, 17, 22 });
            cave.Add(17, new int[] { 16, 18, 23 });
            cave.Add(18, new int[] { 17, 19, 24 });
            cave.Add(19, new int[] { 18, 20, 25 });
            cave.Add(20, new int[] { 19, 21, 26 });
            cave.Add(21, new int[] { 20, 22, 27 });
            cave.Add(22, new int[] { 21, 23, 28 });
            cave.Add(23, new int[] { 22, 24, 29 });
            cave.Add(24, new int[] { 23, 25, 30 });
            cave.Add(25, new int[] { 24, 26, 1 });
            cave.Add(26, new int[] { 1, 3, 20 });
            cave.Add(27, new int[] { 21, 22, 28 });
            cave.Add(28, new int[] { 5, 29, 27 });
            cave.Add(29, new int[] { 23, 24, 5 });
            cave.Add(30, new int[] { 6, 25, 24 });
        }

        public void GenerateCave2()
        {
            cave2.Add(1, new int[] { 25, 26, 2 });
            cave2.Add(2, new int[] { 7, 8, 9 });
            cave2.Add(3, new int[] { 28, 4, 2 });
            cave2.Add(4, new int[] { 10, 28, 11 });
            cave2.Add(5, new int[] { 4, 6, 29 });
            cave2.Add(6, new int[] { 11, 7, 12 });
            cave2.Add(7, new int[] { 2, 12, 13 });
            cave2.Add(8, new int[] { 13, 14, 15 });
            cave2.Add(9, new int[] { 4, 10, 15 });
            cave2.Add(10, new int[] { 9, 17, 15 });
            cave2.Add(11, new int[] { 4, 12, 17 });
            cave2.Add(12, new int[] { 7, 13, 18 });
            cave2.Add(13, new int[] { 7, 8, 18 });
            cave2.Add(14, new int[] { 15, 19, 21 });
            cave2.Add(15, new int[] { 9, 10, 21 });
            cave2.Add(16, new int[] { 17, 22, 23 });
            cave2.Add(17, new int[] { 10, 12, 18 });
            cave2.Add(18, new int[] { 13, 19, 23 });
            cave2.Add(19, new int[] { 14, 20, 24 });
            cave2.Add(20, new int[] { 21, 27, 26 });
            cave2.Add(21, new int[] { 15, 16, 22 });
            cave2.Add(22, new int[] { 21, 23, 28 });
            cave2.Add(23, new int[] { 16, 23, 27 });
            cave2.Add(24, new int[] { 19, 25, 30 });
            cave2.Add(25, new int[] { 24, 26, 20 });
            cave2.Add(26, new int[] { 1, 25, 20 });
            cave2.Add(27, new int[] { 21, 3, 28 });
            cave2.Add(28, new int[] { 5, 29, 22 });
            cave2.Add(29, new int[] { 23, 24, 30 });
            cave2.Add(30, new int[] { 6, 1, 24 });
        }

        public void GenerateCave3()
        {
            cave3.Add(1, new int[] { 6, 26, 2 });
            cave3.Add(2, new int[] { 8, 21, 9 });
            cave3.Add(3, new int[] { 27, 4, 2 });
            cave3.Add(4, new int[] { 5, 9, 11 });
            cave3.Add(5, new int[] { 28, 6, 11 });
            cave3.Add(6, new int[] { 1, 5, 12 });
            cave3.Add(7, new int[] { 2, 1, 13 });
            cave3.Add(8, new int[] { 2, 14, 9 });
            cave3.Add(9, new int[] { 3, 10, 15 });
            cave3.Add(10, new int[] { 4, 16, 15 });
            cave3.Add(11, new int[] { 5, 12, 17 });
            cave3.Add(12, new int[] { 6, 13, 17 });
            cave3.Add(13, new int[] { 14, 7, 12 });
            cave3.Add(14, new int[] { 13, 20, 21 });
            cave3.Add(15, new int[] { 8, 10, 21 });
            cave3.Add(16, new int[] { 21, 22, 17 });
            cave3.Add(17, new int[] { 10, 23, 11 });
            cave3.Add(18, new int[] { 24, 19, 12 });
            cave3.Add(19, new int[] { 25, 18, 13 });
            cave3.Add(20, new int[] { 21, 27, 26 });
            cave3.Add(21, new int[] { 15, 16, 22 });
            cave3.Add(22, new int[] { 27, 15, 22 });
            cave3.Add(23, new int[] { 17, 29, 24 });
            cave3.Add(24, new int[] { 19, 25, 30 });
            cave3.Add(25, new int[] { 1, 30, 19 });
            cave3.Add(26, new int[] { 3, 2, 20 });
            cave3.Add(27, new int[] { 21, 22, 28 });
            cave3.Add(28, new int[] { 5, 29, 4 });
            cave3.Add(29, new int[] { 23, 24, 30 });
            cave3.Add(30, new int[] { 6, 1, 24 });
        }

        public void GenerateCave4()
        {
            cave4.Add(1, new int[] { 6, 7, 2 });
            cave4.Add(2, new int[] { 3, 26, 9 });
            cave4.Add(3, new int[] { 9, 4, 27 });
            cave4.Add(4, new int[] { 10, 28, 11 });
            cave4.Add(5, new int[] { 29, 4, 11 });
            cave4.Add(6, new int[] { 1, 30, 12 });
            cave4.Add(7, new int[] { 2, 1, 13 });
            cave4.Add(8, new int[] { 15, 2, 9 });
            cave4.Add(9, new int[] { 4, 8, 15 });
            cave4.Add(10, new int[] { 9, 11, 16 });
            cave4.Add(11, new int[] { 6, 10, 17 });
            cave4.Add(12, new int[] { 6, 13, 18 });
            cave4.Add(13, new int[] { 19, 7, 12 });
            cave4.Add(14, new int[] { 15, 20, 8 });
            cave4.Add(15, new int[] { 8, 10, 21 });
            //stopped here
            cave4.Add(16, new int[] { 21, 22, 17 });
            cave4.Add(17, new int[] { 10, 23, 11 });
            cave4.Add(18, new int[] { 24, 19, 12 });
            cave4.Add(19, new int[] { 25, 18, 13 });
            cave4.Add(20, new int[] { 21, 27, 26 });
            cave4.Add(21, new int[] { 15, 16, 22 });
            cave4.Add(22, new int[] { 27, 15, 22 });
            cave4.Add(23, new int[] { 17, 29, 24 });
            cave4.Add(24, new int[] { 19, 25, 30 });
            cave4.Add(25, new int[] { 1, 30, 19 });
            cave4.Add(26, new int[] { 3, 2, 20 });
            cave4.Add(27, new int[] { 21, 22, 28 });
            cave4.Add(28, new int[] { 5, 29, 4 });
            cave4.Add(29, new int[] { 23, 24, 30 });
            cave4.Add(30, new int[] { 6, 1, 24 });
        }

        public void GenerateCave5()
        {
        
        }

        public void movePlayer(int cellnumber)
        {
            playerPosition = cellnumber;
        }

        //ADDED TO FIT NEEDED
        public void moveWumpus(int cellNumber)
        {
            wumpusPosition = cellNumber;
        }
        
        public bool isWumpusNear()
        {
            int[] connected = getConnectedRooms(playerPosition, caveNumber);
            for (int i = 0; i < connected.Length; i++)
            {
                if (getWumpusPosition() == connected[i])
                {
                    return true;
                }
            }
            return false;
        }

        public bool areBatsNear()
        {
            int[] connected = getConnectedRooms(playerPosition, caveNumber);
            for (int i = 0; i < connected.Length; i++)
            {
                if (getBatPosition() == connected[i])
                {
                    return true;
                }
            }
            return false; 
        }

        public bool isPitNear()
        {
            int[] connected = getConnectedRooms(playerPosition, caveNumber);
            for (int i = 0; i < connected.Length; i++)
            {
                if (getPitPosition() == connected[i])
                {
                    return true;
                }
            }
            return false; 
        }

        //ADDED THIS TO POSITION WUMPUS IN THE BEGGINING
        public void generateRandomWumpusPosition()
        {
            Boolean loop = true;
            while(loop)
            {
                int randomInt = random.Next(mapSize);
                if(getPlayerPosition() != randomInt)
                {
                    wumpusPosition = randomInt;
                    break;
                }
            }
        }

        //FIXED NAMING TO FIT NEEDS
        public void generateRandomPlayerPosition()
        {
            playerPosition = random.Next(mapSize);
        }



        public int[] getConnectedRooms(int room, int caveNumber)
        {
            if (caveNumber == 1)
            {
                return cave[room];
            }
            else if (caveNumber == 2)
            {
                return cave2[room];
            }
            else if (caveNumber == 3)
            {
                return cave3[room];
            }
            else if (caveNumber == 4)
            {
                return cave4[room];
            }
            else
            {
                return cave5[room];
            }
        }


        public bool isPositionHazardous()
        {
            if (playerPosition == getBatPosition() || playerPosition == getPitPosition())
            {
                return true;
            }
            return false; 
        }

        public int getBatPosition()
        {
            return batPosition; 
        }


        public int getWumpusPosition()
        {
            return wumpusPosition; 
        }

        //CHANGED NAME OF METHOD TO FIT NEEDS
        public int getPlayerPosition()
        {
            return playerPosition;
        }

        public int getPitPosition()
        {
            return pitPosition;
        }

        public void generateBats()
        {
            batPosition = random.Next(mapSize);
        }
        public void generatePit()
        {
            pitPosition = random.Next(mapSize);
        }

       
    }

}
