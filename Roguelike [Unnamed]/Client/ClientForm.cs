using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Roguelike__Unnamed_
{
    public partial class ClientForm : Form
    {
        private World mainWorld;
        private int tileX;
        private int tileY;
        Rectangle tileRectangle;
        public ClientForm()
        {
            InitializeComponent();
            mainWorld = new World(1000, 5);
            mainWorld.generateWorld();
            panel.Height = mainWorld.ResSize;
            panel.Width = mainWorld.ResSize;
        }

        private void panel_Paint(object sender, PaintEventArgs e) //Everytime keypress invalidate form
        {
            for (int Row = 0; Row < mainWorld.MapSize; Row++)
            {
                for (int Column = 0; Column < mainWorld.MapSize; Column++)
                {
                    tileX = Row * 200;
                    tileY = Column * 200;
                    tileRectangle = new Rectangle(tileX, tileY, 200, 200);
                    e.Graphics.DrawImage(mainWorld.Map[Row,Column].image, tileRectangle);
                }
            } 
        }
        public void updateForm()
        {

        }
    }
}
