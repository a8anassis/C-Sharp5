using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Service
{
    internal class MovingSpace
    {
        private IMovable _movable;
        
        public MovingSpace(IMovable movable)
        {
            this._movable = movable;
        }

        public void makeMove5()
        {
            _movable.Move5();
        }
    }
}
