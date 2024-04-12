namespace PrimesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0}\tis{1}prime", i, (IsPrime(i)) ? " " : " not ");
            }
        }

        public static bool IsPrime(int n)
        {
            bool prime = true;
            int divider = 2;
            int maxDivider = (int) Math.Sqrt(n);

            while (prime && (divider <= maxDivider))
            {
                if (n % divider == 0) prime = false;
                divider++;
            }
            return prime;
        }
    }
}