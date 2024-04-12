namespace NullConditionalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string? GetUpperStr()
        {
            string? s;

            Console.WriteLine("Please insert a string");
            s = Console.ReadLine();

            return s?.ToUpper();
        }
    }
}