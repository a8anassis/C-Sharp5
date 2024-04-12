namespace Max2x2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 2, 3, 4, 5, 6 },
                { 2, 3, 4, 5, 6, 7 },
                { 3, 4, 5, 6, 1, 8 },
                { 4, 5, 6, 7, 1, 1 },
            };

            int maxSum = int.MinValue;
            int row = 0;
            int col = 0;
            
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j+1] + matrix[i+1, j] + matrix[i+1, j+1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        row = i;
                        col = j;
                    }
                }
            }

            Console.WriteLine($"Max Sum: {maxSum}, row: {row}, column: {col}");
        }


    }
}