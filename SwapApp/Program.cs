namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            int b = 20;

            Console.WriteLine($"a: {a}, b: {b}");
            // Swap(a, b);
            Swap(ref a, ref b);
            Console.WriteLine($"a: {a}, b: {b}");*/
            string? s = "Hello";
            ChangeStr(out s);
            Console.WriteLine($"s: {s}");
        }


        /// <summary>
        /// Swap gets args by value.
        /// </summary>
        /// <param name="a">The first input.</param>
        /// <param name="b">The second input.</param>
        public static void Swap(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }


        public static void Swap(ref int a, ref int b)
        {
            /*int tmp = a;
            a = b;
            b = tmp;*/
            (a, b) = (b, a);
        }

        public static void ChangeStr(out string str)
        {
            str = "AUEB";
        }
    }
}