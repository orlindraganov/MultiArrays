using System;



class Program
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        char fillType = Convert.ToChar(Console.ReadLine());

        int number = 1;

        int[,] arr = new int[arraySize, arraySize];

        if (fillType == 'a')
        {
            for (int x = 0; x < arraySize; x++)
            {
                for (int y = 0; y < arraySize; y++)
                {
                    arr[y, x] = number;
                    number++;
                }
            }
        }

        else if (fillType == 'b')
        {
            for (int x = 0; x < arraySize; x += 2)
            {
                for (int y = 0; y < arraySize; y++)
                {
                    arr[y, x] = number;
                    number++;
                }
                for (int y = arraySize - 1; y >= 0; y--)
                {
                    arr[y, x + 1] = number;
                    number++;
                }
            }
        }

        for (int x = 0; x < arraySize; x++)
        {
            for (int y = 0; y < arraySize; y++)
            {
                Console.Write(arr[x, y] + " ");
            }
            Console.WriteLine();
        }

    }
}
