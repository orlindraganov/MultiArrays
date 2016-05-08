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
            for (int y = 0; y < arraySize; y++)
            {
                for (int x = 0; x < arraySize; x++)
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
                    arr[x, y] = number;
                    number++;
                }
                if (x + 1 < arraySize)
                {
                    for (int y = arraySize - 1; y >= 0; y--)
                    {
                        arr[x + 1, y] = number;
                        number++;
                    }
                }
            }
        }
        else if (fillType == 'c')
        {
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    arr[j, arraySize - i + j - 1] = number;

                    if (i < arraySize - 1)
                    {
                        arr[arraySize - 1 - j, i - j] = arraySize * arraySize + 1 - number;
                    }
                    number++;
                }
            }
        }

        else if (fillType == 'd')
        {
            string direction = "down";
            int xArr = 0;
            int yArr = 0;

            while (number <= arraySize * arraySize)
            {
                if (direction == "down")
                {
                    if ((yArr == arraySize - 1) || (arr[xArr, yArr + 1] != 0))
                    {
                        direction = "right";
                    }
                    else
                    {
                        arr[xArr, yArr] = number;
                        number++;
                        yArr++;
                        if (number == arraySize * arraySize)
                        {
                            arr[xArr, yArr] = number;
                            break;
                        }
                    }
                }
                else if (direction == "right")
                {
                    if ((xArr == arraySize - 1) || (arr[xArr + 1, yArr] != 0))
                    {
                        direction = "up";
                    }
                    else
                    {
                        arr[xArr, yArr] = number;
                        number++;
                        xArr++;
                        if (number == arraySize * arraySize)
                        {
                            arr[xArr, yArr] = number;
                            break;
                        }
                    }
                }
                else if (direction == "up")
                {
                    if ((yArr == 0) || (arr[xArr, yArr - 1] != 0))
                    {
                        direction = "left";
                    }
                    else
                    {
                        arr[xArr, yArr] = number;
                        number++;
                        yArr--;
                        if (number == arraySize * arraySize)
                        {
                            arr[xArr, yArr] = number;
                            break;
                        }
                    }
                }
                else if (direction == "left")
                {
                    if ((xArr == 0) || (arr[xArr - 1, yArr] != 0))
                    {
                        direction = "down";
                    }
                    else
                    {
                        arr[xArr, yArr] = number;
                        number++;
                        xArr--;
                        if (number == arraySize * arraySize)
                        {
                            arr[xArr, yArr] = number;
                            break;
                        }
                    }
                }
            }
        }

        for (int y = 0; y < arraySize; y++)
        {
            for (int x = 0; x < arraySize - 1; x++)
            {
                Console.Write(arr[x, y] + " ");
            }
            Console.WriteLine(arr[arraySize - 1, y]);
        }
    }
}
