using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp.Model
{
    internal class Point
    {
        public int X { get; set; }

        public Point()
        {

        }

        public Point(int x)
        {
            X = x;
        }

        /// <summary>
        /// Static factory.
        /// </summary>
        /// <returns>A default (X=0) new point</returns>
        public static Point GetPoint()
        {
            return new Point();
        } 

        public virtual void Move5()
        {
            X += 5;
        }

        public override string ToString()
        {
            return $"{{{X}}}";
        }

    }
}
