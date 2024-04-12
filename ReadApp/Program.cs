namespace ReadApp
{
    /// <summary>
    /// Διαβάσει δύο ακεραίους από το std input
    /// και εκτύπώνει το άθροισμά τους.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            Console.WriteLine("Please insert two ints");
            num1 = int.Parse(Console.ReadLine()!);
            num2 = int.Parse(Console.ReadLine()!);

            result = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {result}");
        }
    }
}