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
        public ClientForm()
        {
            InitializeComponent();
            mainWorld = new World(800, 5);
            mainWorld.generateWorld();
            panel.Height = mainWorld.ResSize;
            panel.Width = mainWorld.ResSize;
            foreach (var item in mainWorld.Map)
            {
                Console.WriteLine(item.image.ToString()); 
            }

        }

        private void panel_Paint(object sender, PaintEventArgs e) //Everytime keypress invalidate form
        {
            Image m = mainWorld.Map[mainWorld.MapSize / 2, mainWorld.MapSize / 2].image;
            e.Graphics.DrawImage(m, Location);
        }
        public void updateForm()
        {

        }
    }
}
