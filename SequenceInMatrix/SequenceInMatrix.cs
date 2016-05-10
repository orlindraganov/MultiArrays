using System;



class SequenceInMatrix
{
    static void Main()
    {
        string[] strSizes = new string[2];
        strSizes = Console.ReadLine().Split(' ');
        int[] sizes = new int[2];

        for (int i = 0; i < strSizes.Length; i++)
        {
            sizes[i] = int.Parse(strSizes[i]);
        }

        int maxLength = int.MinValue;
        string currentValue = null;
        int currentLength = 1;

        string[,] matrix = new string[sizes[1], sizes[0]];
        string[] inputs = new string[sizes[1]];

        for (int i = 0; i < sizes[0]; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            for (int j = 0; j < sizes[1]; j++)
            {
                matrix[j, i] = inputs[j];
            }
        }
        //Search for rows
        for (int y = 0; y < sizes[0]; y++)
        {
            for (int x = 0; x < sizes[1]; x++)
            {
                if (matrix[x, y] == currentValue)
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                    currentValue = matrix[x, y];
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            currentValue = null;
        }

        //Search for cols
        for (int x = 0; x < sizes[1]; x++)
        {
            for (int y = 0; y < sizes[0]; y++)
            {
                if (matrix[x, y] == currentValue)
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                    currentValue = matrix[x, y];
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            currentValue = null;
        }

    }
}
