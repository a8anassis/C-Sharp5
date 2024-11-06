namespace ArrayUtil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3};

            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            //Array.Reverse(arr);

            int[] reversed = new int[arr.Length];
            Array.Copy(arr, reversed, arr.Length);

            Array.Reverse(reversed);

            foreach (int item in reversed)
            {
                Console.Write($"{item} ");
            }
        }
    }
}