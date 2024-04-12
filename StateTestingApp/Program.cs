namespace StateTestingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0.0m;

            Console.WriteLine("Please insert two nums");

            if (!decimal.TryParse(Console.ReadLine(), out decimal num1))
            {
                Console.WriteLine("Error in decimal reading");
            }

            if (!decimal.TryParse(Console.ReadLine(), out decimal num2))
            {
                Console.WriteLine("Error in decimal reading");
            }

            sum = num1 + num2;

            Console.WriteLine($"The sum of {num1} and {num2} = {sum}");
        }
    }
}