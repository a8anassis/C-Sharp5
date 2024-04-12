using InterfacesApp.Service;

namespace InterfacesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable movable = new Point2D()
            {
                X = 10,
                Y = 20
            };

            movable.Move10();
            Console.WriteLine(movable);

            IMovable p1 = new Point()
            {
                X = 5
            };

            IMovable p2 = new Point2D()
            {
                X = 4,
                Y = 6
            };

            MovingSpace ms1 = new(p1);
            MovingSpace ms2 = new(p2);

            ms1.makeMove5();
            ms2.makeMove5();

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}