namespace ParamsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.WriteLine(Add(new int[] {1, 2, 3, 4}));
            Console.WriteLine(Add(null!));
        }

        /// <summary>
        /// Returns the sum of the input params.
        /// </summary>
        /// <param name="nums">the array of nums.</param>
        /// <returns>The sum of nums if exist, 0 otherwise</returns>
        public static int Add(params int[] nums)
        {
            int sum = 0;

            if (nums is null)
            {
                return 0;
            }

            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }
}