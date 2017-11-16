using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class controller
    {
        public World mainWorld { get; private set; }
        static void Main(string[] args)
        {
            mainWorld.generateWorld();
        }
    }
}
