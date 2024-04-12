using System.Net.Http.Headers;

namespace ArraysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            arr1[0] = 1;

            int[] arr2 = { 1, 2, 3 };

            int[] arr3; 
            arr3 = new int[] { 1, 2, 3 };

            Console.WriteLine(arr3.Length);

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            foreach (int item in arr2)
            {
                Console.WriteLine(item);
            }


            int[,] grid = new int[3, 4];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.WriteLine(grid[i,j]);
                }
            }

            //Jagged
            int[][] jagged = new int[4][];
            jagged[0] = new int[4];
            jagged[1] = new int[2];
            jagged[2] = new int[6];
            jagged[3] = new int[8];
        }
    }
}