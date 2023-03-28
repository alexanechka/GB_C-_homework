/* Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j > 0)
            {
                Console.Write(" ");
            }

            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[5, 5];

int i = 0;
int iMin = 0;
int iMax = matrix.GetLength(0);
int number = 1;
int j = -1;
int jMin = -1;
int jMax = matrix.GetLength(1);
int k;

while (jMax - jMin > 1 | iMax - iMin > 1)

{
    Console.WriteLine($"i = {i}, j = {j}, iMin = {iMin}, iMax = {iMax}, jMin = {jMin}, jMax = {jMax}");
    if (i == iMin & j == jMin)
    {
        j++;
        for (k = j; k < jMax; k++)
        {
            matrix[i, k] = number;
            number++;
            j = k;
        }
        jMax = j;
    }
    Console.WriteLine($"i = {i}, j = {j}, iMin = {iMin}, iMax = {iMax}, jMin = {jMin}, jMax = {jMax}");

    if (i == iMin & j == jMax)
    {
        i++;
        for (k = i; k < iMax; k++)
        {
            matrix[k, j] = number;
            number++;
            i = k;
        }
        iMax = i;
    }
    Console.WriteLine($"i = {i}, j = {j}, iMin = {iMin}, iMax = {iMax}, jMin = {jMin}, jMax = {jMax}");

    if (i == iMax & j == jMax)
    {
        j--;
        for (k = j; k > jMin; k--)
        {
            matrix[i, k] = number;
            number++;
            j = k;
        }
        jMin = j;
    }
    Console.WriteLine($"i = {i}, j = {j}, iMin = {iMin}, iMax = {iMax}, jMin = {jMin}, jMax = {jMax}");

    if (i == iMax & j == jMin)
    {
        i--;
        for (k = i; k > iMin; k--)
        {
            matrix[k, j] = number;
            number++;
            i = k;
        }
        iMin = i;
    }
    Console.WriteLine($"i = {i}, j = {j}, iMin = {iMin}, iMax = {iMax}, jMin = {jMin}, jMax = {jMax}");
}


PrintMatrix(matrix);