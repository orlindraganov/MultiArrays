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



        //Search diag right

        if (sizes[1] > sizes[0])
        {
            for (int searches = 0; searches < sizes[1] - sizes[0] + 1; searches++)
            {
                for (int checks = 0; checks < sizes[0]; checks++)
                {
                    if (matrix[searches + checks, checks] == currentValue)
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                        currentValue = matrix[searches + checks, checks];
                    }
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                currentValue = null;
            }
        }
        else
        {
            for (int searches = 0; searches < sizes[0] - sizes[1] + 1; searches++)
            {
                for (int checks = 0; checks < sizes[1]; checks++)
                {
                    if (matrix[checks, searches + checks] == currentValue)
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                        currentValue = matrix[checks, checks + searches];
                    }
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                currentValue = null;
            }
        }

        //search for small triangles

        for (int searches = 1; searches < Math.Min(sizes[0], sizes[1]); searches++)
        {
            for (int checks = 0; checks < searches; checks++)
            {
                if (matrix[checks, sizes[0] - 1 - searches + checks] == currentValue)
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                    currentValue = matrix[checks, sizes[0] - 1 - searches + checks];
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            currentValue = null;

            for (int checks = 0; checks < searches; checks++)
            {
                if (matrix[sizes[1] - 1 - searches + checks, checks] == currentValue)
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                    currentValue = matrix[sizes[1] - 1 - searches + checks, checks];
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }

            currentValue = null;
        }

        //Search diag left

        if (sizes[1] > sizes[0])
        {
            for (int searches = 0; searches < sizes[1] - sizes[0] + 1; searches++)
            {
                for (int checks = 0; checks < sizes[0]; checks++)
                {
                    if (matrix[searches + checks, sizes[0] - 1 - checks] == currentValue)
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                        currentValue = matrix[searches + checks, sizes[0] - 1 - checks];
                    }
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                currentValue = null;
            }
        }
        else
        {
            for (int searches = 0; searches < sizes[0] - sizes[1] + 1; searches++)
            {
                for (int checks = 0; checks < sizes[1]; checks++)
                {
                    if (matrix[sizes[1] - 1 - checks, searches + checks] == currentValue)
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                        currentValue = matrix[sizes[1] - 1 - checks, checks + searches];
                    }
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                currentValue = null;
            }
        }

        //search for small triangles

        for (int searches = 1; searches < Math.Min(sizes[0], sizes[1]); searches++)
        {
            for (int checks = 0; checks < searches; checks++)
            {
                if (matrix[checks, searches - checks] == currentValue)
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                    currentValue = matrix[checks, searches - checks];
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            currentValue = null;

            for (int checks = 0; checks < searches; checks++)
            {
                if (matrix[sizes[1] - 1 - searches + checks, sizes[0] - 1 - checks] == currentValue)
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                    currentValue = matrix[sizes[1] - 1 - searches + checks, sizes[0] - 1 - checks];
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }

            currentValue = null;
        }




        Console.WriteLine(maxLength);
    }
}
