namespace FiboRecursiveApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"{i}:  {Fibo(i)} ");
            }
        }

        public static int Fibo(int n)
        {
            if (n <= 0) return 0;
            return (n > 2) ? Fibo(n-1) + Fibo(n-2) : 1;
        }
    }
}