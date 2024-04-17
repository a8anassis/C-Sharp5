using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointMonolithicApp.Model
{
    internal class Point : IEquatable<Point>, IComparable<Point>
    {
        public int X { get; set; }

        private readonly static IList<Point> _points = new List<Point>();
        public static IList<Point> Points { get { return new List<Point>(_points); } }


        public int CompareTo(Point? other)
        {
            if (other == null) throw new ArgumentNullException(nameof(other) + " can not compare to a null point");
            return X - other.X;
        }

        public bool Equals(Point? other)
        {
            if (other == null) return false;
            return CompareTo(other) == 0;
        }

        public override string? ToString()
        {
            return $"({X})";
        }

        public static bool operator >(Point? left, Point? right)
        {
            if (left == null || right == null) return false;
            return left.X > right.X;
        }

        public static bool operator <(Point? left, Point? right)
        {
            if (left == null || right == null) return false;
            return left.X < right.X;
        }

        public static bool operator >=(Point? left, Point? right)
        {
            if (left == null || right == null) return false;
            return left.X >= right.X;
        }

        public static bool operator <=(Point? left, Point? right)
        {
            if (left == null || right == null) return false;
            return left.X <= right.X;
        }

        public static bool operator ==(Point? left, Point? right)
        {
            if (left == null || right == null) return false;
            return left.X == right.X;
        }

        public static bool operator !=(Point? left, Point? right)
        {
            if (left == null || right == null) return false;
            return left.X != right.X;
        }


        // CRUD API
        public void Insert()
        {
            _points.Add(this);
        }

        public bool Update(Point? point)
        {
            int positionToUpdate = GetPointPosition();
            if (positionToUpdate == -1)
            {
                return false;
            }
            _points[positionToUpdate] = point!;
            return true;
        }

        public Point? Delete()
        {
            int positionToDelete = GetPointPosition();
            if (positionToDelete == -1)
            {
                return null;
            }

            Point? pointToReturn = _points[positionToDelete];
            _points.RemoveAt(positionToDelete);
            return pointToReturn;
        }

        public Point? GetPoint()
        {
            return (_points.Contains(this) ? _points[GetPointPosition()] : null);
        }



        private int GetPointPosition()
        {
            return _points.IndexOf(this);
        }

        // Service API

        public void InsertPoint()
        {
            Insert();
        }

        public Point? UpdatePoint(Point? point)
        {
            if (!Update(point)) return null;
            return this;
        }

        public Point? DeletePoint()
        {
            return Delete();
        }

        public Point? GetPointOrNull()
        {
            return GetPoint();
        }

        public static List<Point> GetAllPoints()
        {
            return new List<Point>(_points);
        }

    }
}
