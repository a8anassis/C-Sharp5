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

            Array.Reverse(arr);

            int[] reversed = new int[arr.Length];
            Array.Copy(arr, reversed, arr.Length);
        }
    }
}