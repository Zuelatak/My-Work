using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace Model
{
    public class Tile
    { 
        public Image image;
        public bool top;
        public bool left;
        public bool right;
        public bool bot;
        public Tile(string tileName)
        {
            if (tileName == "2Way")
            {
                image = Image.FromFile("../../../Resources/Images/2-way.jpg");
                top = true;
                left = false;
                right = false;
                bot = true;
            }
            else if (tileName == "3Way")
            {
                image = Image.FromFile("../../../Resources/Images/3-way.jpg");
                top = true;
                left = true;
                right = false;
                bot = true;
            }
            else if (tileName == "4Way")
            {
                image = Image.FromFile("../../../Resources/Images/4-way.jpg");
                top = true;
                left = true;
                right = true;
                bot = true;
            }
            else if (tileName == "LTile")
            {
                image = Image.FromFile("../../../Resources/Images/L.jpg");
                top = true;
                left = true;
                right = false;
                bot = false;
            }
            else if (tileName == "EndTile")
            {
                image = Image.FromFile("../../../Resources/Images/End.jpg");
                top = true;
                left = false;
                right = false;
                bot = false;
            }
            else if(tileName == "Empty")
            {
                image = Image.FromFile("../../../Resources/Images/Black.jpg");
                top = false;
                left = false;
                right = false;
                bot = false;
            }
        }
        public void Rotate()
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            bool tempTop = top;
            bool tempLeft = left;
            bool tempRight = right;
            bool tempBot = bot;
            right = tempBot;
            bot = tempLeft;
            left = tempTop;
            top = tempRight;
        }
    }
}

