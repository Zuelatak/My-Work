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
        private World m;
        public ClientForm()
        {
            InitializeComponent();
            m = new World();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            PointF Location = new PointF(125, 175);
            m.k.Roate();
            e.Graphics.DrawImage(m.k.image, Location);
        }
    }
}
