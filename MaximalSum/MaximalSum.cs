using System;
class Program
{
    static void Main()
    {
        string[] strSizes = new string[2];
        strSizes = Console.ReadLine().Split(' ');
        int[] sizes = new int[2];
        long maxSum = long.MinValue;

        for (int i = 0; i < strSizes.Length; i++)
        {
            sizes[i] = int.Parse(strSizes[i]);
        }

        string[] strRow = new string[sizes[1]];
        int[,] matrix = new int[sizes[1], sizes[0]];

        for (int i = 0; i < sizes[0]; i++)
        {
            strRow = Console.ReadLine().Split(' ');
            for (int j = 0; j < sizes[1]; j++)
            {
                matrix[j, i] = int.Parse(strRow[j]);
            }
        }

        for (int y = 0; y < sizes[0] - 2; y++)
        {
            for (int x = 0; x < sizes[1] - 2; x++)
            {
                long currentSum = matrix[x, y] + matrix[x + 1, y] + matrix[x + 2, y]
                    + matrix[x, y + 1] + matrix[x + 1, y + 1] + matrix[x + 2, y + 1]
                    + matrix[x, y + 2] + matrix[x + 1, y + 2] + matrix[x + 2, y + 2];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}