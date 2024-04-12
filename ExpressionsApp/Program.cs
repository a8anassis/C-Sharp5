namespace ExpressionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 40;

            int sum = 0;
            int mul = 0;
            int div = 0;
            int mod = 0;

            int result1 = 0;
            long result2 = 0;
            int result3 = 0;


            sum = num1 + num2;
            mul = num2 * num3;
            div = num1 / num4;
            mod = num1 % num4;

            result1 = sum++;
            result1 = sum + 1;
            result2 = result2 + 5;
            result2 += 5;

            result2 = (num1 > 0) ? 10 : 0;
            result3 = Math.Abs(num3);

        }
    }
}