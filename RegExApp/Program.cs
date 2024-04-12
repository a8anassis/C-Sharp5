using System.Text.RegularExpressions;

namespace RegExApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string? op;
            int result = 0;
            string? expr;

            Console.WriteLine("Please insert an (int) expression");
            expr = Console.ReadLine();

            string[] tokens = Regex.Split(expr!, @"\s+");
            num1 = int.Parse(tokens[0]);
            num2 = int.Parse(tokens[2]);
            op = tokens[1];

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        result = 0;
                    } else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    result = 0;
                    break;
            }
        }
    }
}