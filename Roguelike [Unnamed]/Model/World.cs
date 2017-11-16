using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{

    public class World
    {
        public Tile[,] Map { get; private set; }
        private Tile testTile;
        private List<string> tileOptions = new List<string>();
        private Random random = new Random();
        public int ResSize { get; private set; }
        public int MapSize { get; private set; }
        private bool top = true;
        private bool left = true;
        private bool right = true;
        private bool bot = true;
        private bool tileWorks = false;
        private int tryCounter = 0;
        private string randomTile;
        public World(int resSize, int mapSize)
        {
            ResSize = resSize;
            MapSize = mapSize;
            Map = new Tile[mapSize-1,mapSize-1]; //Row , Column
            tileOptions.Add("2Way"); tileOptions.Add("3Way"); tileOptions.Add("4Way"); tileOptions.Add("LTile"); tileOptions.Add("EndTile");
        }
        public void generateWorld()
        {

            for (int Row = 0; Row < MapSize; Row++)
            {
                for (int Column = 0; Column < MapSize; Column++)
                {
                    if(Row == 0) //If Row == 0
                    {
                        top = false;
                    }
                    if (Row == MapSize - 1) //If Row == Max Size
                    {
                        bot = false;
                    }
                    if(Column == 0) //If Column == 0
                    {
                        left = false;
                    }
                    if(Column == MapSize - 1) //If Column == Max Size
                    {
                        right = false;
                    }
                    if(Row != 0 && Map[Row - 1, Column].bot == false)
                    {
                        bot = false;
                    }
                    if (Row != MapSize-1 && Map[Row + 1, Column].top == false)
                    {
                        top = false;
                    }
                    if (Column != 0 && Map[Row, Column - 1].right == false)
                    {
                        bot = false;
                    }
                    if (Column != MapSize - 1 && Map[Row, Column + 1].bot == false)
                    {
                        bot = false;
                    }
                    while (!tileWorks)
                    {
                        tryCounter++;
                        randomTile = tileOptions[random.Next(0,4)];   //TODO: Tweak this so map is more tiles than black space
                        testTile = new Tile(randomTile);
                        for (int counter = 0; counter < 4; counter++)
                        {
                            if (testTile.top == top && testTile.left == left && testTile.bot == bot && testTile.right == right)
                            {
                                tileWorks = true;
                                Map[Row, Column] = testTile;
                            }
                            testTile.Rotate();
                        }
                        if(tryCounter == 15)
                        {
                            tileWorks = true;
                            Map[Row, Column] = new Tile("Empty");
                        }
                    }
                }
            }
        }
    }
}
