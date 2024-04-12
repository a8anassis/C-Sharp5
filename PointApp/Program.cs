using PointApp.Model;

namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new()
            {
                new Point(), new Point(5),
                new Point2D(), new Point2D(1, 2),
                new Point3D(), new Point3D(1, 2, 3)
            };

            foreach (Point point in points)
            {
                Console.WriteLine(point);
            }

            Point p1 = new(5);
            Point p11 = Point.GetPoint();

            Point2D p2 = new(5, 12);
            Point3D p3 = new Point3D(1, 2, 3);

            Point p4 = new Point2D(5, 6);
            Point p5 = new Point3D(5, 6, 9);

            p3.Move5();

            p5.Move5();

            //Console.WriteLine(p5);
            DoPrint(p1);
            DoPrint(p11);
            DoPrint(p2);

            DoMove5(p5);
            DoPrint(p3);
            DoPrint(p4);
        }

        public static void DoPrint(Point point)
        {
            Console.WriteLine(point);
        }

        public static void DoMove5(Point point)
        {
            point.Move5();
        }


    }
}