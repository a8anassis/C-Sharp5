using System.Numerics;

namespace PowerApp
{

    /// <summary>
    /// Υπολογίζει τη δύναμη του 2^10
    /// με for.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int myBase = 2;
            int myPower = 10;
            BigInteger result = 1;

            for (int i = 1; i <= myPower; i++)
            {
                result *= myBase;
            }

            Console.WriteLine($"{myBase} ^ {myPower} = {result}");
        }
    }
}