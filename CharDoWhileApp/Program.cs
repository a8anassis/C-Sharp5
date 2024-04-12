namespace CharDoWhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ord;

            do
            {
                Console.WriteLine("Please insert a char");
                ord = Console.Read();
                Console.WriteLine($"Char: {(char) ord}, Ordinal: {ord}");

            } while (ord != 10);
        }
    }
}