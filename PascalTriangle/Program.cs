namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int HEIGHT = 15;

            int[][] triangle = new int[HEIGHT][];

            for (int row = 0; row < HEIGHT; row++)
            {
                triangle[row] = new int[row + 1];
            }

            triangle[0][0] = 1;
            for (int i = 0; i < HEIGHT - 1; i++)
            {
                for (int j = 0; j <= i; j++) 
                {
                    triangle[i + 1][j] += triangle[i][j];
                    triangle[i + 1][j + 1] += triangle[i][j];
                }
            }

            for (int i = 0; i < HEIGHT; i++)
            {
                for (int k = 1; k <= (HEIGHT - i) * 2 ; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{triangle[i][j], 5}");
                }
                Console.WriteLine();
            }
        }
    }
}