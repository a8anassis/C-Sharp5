using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Service
{
    internal class Point : AbstractPoint, IMovable
    {
        public override string ToString()
        {
            return $"({X}";
        }
    }
}
