using System.Globalization;


namespace OutputApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10_123_123;
            int num1 = 20_000_123;

            //Console.WriteLine("Hello, World!");
            //Console.Write("Hello");
            //Console.WriteLine();

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("Num: " + num);
            Console.WriteLine("Num: {0,6:N2} {1:C2}", num, num1);

            Console.WriteLine($"Num: {num}, Num1: {num1}");
        }
    }
}