using System.Text;

namespace StringBuilderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine(DateTime.Now);
            for (int i = 1; i <= 50_000_000; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(sb.ToString().Substring(0, 24));
        }
    }
}