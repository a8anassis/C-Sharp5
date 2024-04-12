namespace ExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Please insert a num");
                    num = int.Parse(Console.ReadLine()!);

                    Console.WriteLine(num);
                    if (num == 0) break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error in imput format" + e.Message);
                    //throw;
                }
            }
        }
    }
}