namespace OutputApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num1 = 20;
            
            Console.WriteLine("Hello, World!");
            Console.Write("Hello");
            Console.WriteLine();

            Console.WriteLine("Num: " + num);
            Console.WriteLine("Num: {0:N0} {1}", num, num1);

            Console.WriteLine($"Num: {num}, Num1: {num1}");
        }
    }
}