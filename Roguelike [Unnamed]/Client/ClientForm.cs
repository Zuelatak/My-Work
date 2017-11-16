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
using Controller;

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
            mainWorld = new World(800, 10);
            panel.Height = mainWorld.ResSize;
            panel.Width = mainWorld.ResSize;


        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            PointF Location = new PointF(0, 0);
            m.k.Rotate();
            e.Graphics.DrawImage(m.k.image, Location);
            if (controller.World != null)
            {
                {
                    panel.Width = controller.World.Size;
                    panel.Height = controller.World.Size;
                    foreach (Ship ship in controller.mainWorld.getTiles())
                    {
                        if (!currentShipSprites.ContainsKey(ship.ID))
                        {
                            currentShipSprites.Add(ship.ID, shipSprites[currentShipSprite % shipSprites.Length]);
                            currentShipSprite++;
                        }

                        DrawObjectWithTransform(e, ship, controller.World.Size, ship.X, ship.Y, ship.Angle, ShipDrawer);
                    }

                    foreach (Star star in controller.World.GetStars())
                    {
                        DrawObjectWithTransform(e, star, controller.World.Size, star.X, star.Y, 0, StarDrawer);
                    }

                    foreach (Projectile projectile in controller.World.GetProjectiles())
                    {
                        DrawObjectWithTransform(e, projectile, controller.World.Size, projectile.X, projectile.Y,
                            projectile.Angle, ProjectileDrawer);
                    }
                }
            }
            else
            {
                PointF Location = new PointF(125, 175);
                Image Welcome = Image.FromFile("../../../Resources/Images/Welcome.png");
                e.Graphics.DrawImage(Welcome, Location);
            }
        }
        private void TileDrawer(object o, PaintEventArgs e)
        {
            Image temp = mainWorld.Map[((Ship)o).ID];
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(i, shipDestRectangle, 0, 0, i.Width, i.Height, GraphicsUnit.Pixel);
        }
    }
}
