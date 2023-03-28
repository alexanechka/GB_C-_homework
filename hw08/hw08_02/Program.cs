/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] matrix = new int[4, 4];

matrix[0, 0] = 1;
matrix[0, 1] = 4;
matrix[0, 2] = 7;
matrix[0, 3] = 2;
matrix[1, 0] = 5;
matrix[1, 1] = 9;
matrix[1, 2] = 2;
matrix[1, 3] = 3;
matrix[2, 0] = 8;
matrix[2, 1] = 4;
matrix[2, 2] = 2;
matrix[2, 3] = 4;
matrix[3, 0] = 5;
matrix[3, 1] = 2;
matrix[3, 2] = 6;
matrix[3, 3] = 7;

int MinElementSumString(int[,] matrix)
{
    int stringNumber = 0;
    int minSum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (i == 0)
        {
            minSum = sum;
            stringNumber = i + 1;
        }
        else
        {
            if (minSum > sum)
            {
                minSum = sum;
                stringNumber = i + 1;
            }

        }
    }
    return stringNumber;
}

Console.WriteLine($"Минимальная сумма находится в {MinElementSumString(matrix)} строке");