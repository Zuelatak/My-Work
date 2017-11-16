﻿using System;
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
            Map = new Tile[mapSize, mapSize]; //Row , Column
            tileOptions.Add("2Way"); tileOptions.Add("3Way"); tileOptions.Add("4Way"); tileOptions.Add("LTile"); tileOptions.Add("EndTile");
        }
        public void generateWorld()
        {
            generate(MapSize / 2, MapSize / 2);
        }
        private void generate(int Row, int Column)
        {
                if (Row == 0) //If Row == 0
                {
                    top = false;
                }
                if (Row == MapSize - 1) //If Row == Max Size
                {
                    bot = false;
                }
                if (Column == 0) //If Column == 0
                {
                    left = false;
                }
                if (Column == MapSize - 1) //If Column == Max Size
                {
                    right = false;
                }
            if (Map[Row, Column] != null)
            {
                if (Row != 0 && Map[Row - 1, Column].bot == false)
                {
                    bot = false;
                }
                if (Row != MapSize - 1 && Map[Row + 1, Column].top == false)
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
            }

            while (!tileWorks)
            {
                tryCounter++;
                randomTile = tileOptions[random.Next(0, 4)];   //TODO: Tweak this so map is more tiles than black space
                testTile = new Tile(randomTile);
                for (int counter = 0; counter < 3; counter++)
                {
                    if (testTile.top == top && testTile.left == left && testTile.bot == bot && testTile.right == right)
                    {
                        tileWorks = true;
                        Map[Row, Column] = testTile;
                    }
                    testTile.Rotate();
                }
                if (tryCounter == 15)
                {
                    tileWorks = true;
                    Map[Row, Column] = new Tile("Empty");
                }
               // if (Row == MapSize / 2 && Column == MapSize / 2)
               // {
               //     tileWorks = true;
               //     Map[Row, Column] = new Tile("4Way");
               // }
            }
            top = true;
            left = true;
            right = true;
            bot = true;
            tileWorks = false;
            tryCounter = 0; //Why did this break everything :(
            if (Row != 0 && Map[Row-1,Column] == null)
            {
                generate(Row - 1, Column);
            }
            if (Column != 0 && Map[Row, Column - 1] == null)
            {
                generate(Row, Column - 1);
            }
            if (Column != MapSize - 1 && Map[Row, Column + 1] == null)
            {
                generate(Row, Column + 1);
            }
            if (Row != MapSize - 1 && Map[Row + 1, Column] == null)
            {
                generate(Row + 1, Column);
            }
        }
        public IEnumerable<Tile> getTiles()
        {
            foreach (var item in Map)
            {
                yield return item;
            }
        }
    }
}

