using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{
    public class Map : IMap
    {
        Cave [] cave;
        int playerPosition;
        const int mapSize = 30;
        int batPosition;
        int pitPosition;
        int wumpusPosition;
        //added new private member variable Random to ensure randomness
        private Random random = new Random();
        
        public void Generate()
        {
           Cave [] cave = new Cave [mapSize];
        }

        public void movePlayer(int cellnumber)
        {
            playerPosition = cellnumber;
        }
        
        public bool isWumpusNear()
        {
            int[] connected = getConnectedRooms(playerPosition);
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
            int[] connected = getConnectedRooms(playerPosition);
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
            int[] connected = getConnectedRooms(playerPosition);
            for (int i = 0; i < connected.Length; i++)
            {
                if (getPitPosition() == connected[i])
                {
                    return true;
                }
            }
            return false; 
        }

        public int getStartPosition()
        {
            return 0;
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



        public int[] getConnectedRooms(int room)
        {
            return new[] { 2, 7, 9 };
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

       
    }

}
