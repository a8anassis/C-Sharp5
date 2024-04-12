using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Service
{
    internal class Point2D : AbstractPoint, IMovable
    {
        public int Y { get; set; }

        public override void Move5()
        {
            base.Move5();
            Y += 5;
        }

        public override void Move10()
        {
            base.Move10();
            Y += 10;
        }

        public override string ToString()
        {
            return $"({X} , {Y})";
        }
    }
}
