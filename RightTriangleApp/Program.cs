namespace RightTriangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double EPSILON = 0.0005;
            double a = 0.0;
            double b = 0.0;
            double c = 0.0;
            bool isRight = false;

            Console.WriteLine("Please insert three doubles");
            a = double.Parse(Console.ReadLine()!);
            b = double.Parse(Console.ReadLine()!);
            c = double.Parse(Console.ReadLine()!);

            isRight = Math.Abs(a * a - b * b - c * c) <= EPSILON;

            Console.WriteLine($"The triangle is{0}right: ", (isRight) ? " " : " not ");
        }
    }
}