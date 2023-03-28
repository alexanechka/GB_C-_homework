/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */

int[,] matrixFirst = new int[4, 4];

matrixFirst[0, 0] = 1;
matrixFirst[0, 1] = 4;
matrixFirst[0, 2] = 7;
matrixFirst[0, 3] = 2;
matrixFirst[1, 0] = 5;
matrixFirst[1, 1] = 9;
matrixFirst[1, 2] = 2;
matrixFirst[1, 3] = 3;
matrixFirst[2, 0] = 8;
matrixFirst[2, 1] = 4;
matrixFirst[2, 2] = 2;
matrixFirst[2, 3] = 4;
matrixFirst[3, 0] = 5;
matrixFirst[3, 1] = 2;
matrixFirst[3, 2] = 6;
matrixFirst[3, 3] = 7;

int[,] matrixSecond = new int[4, 4];

matrixSecond[0, 0] = 1;
matrixSecond[0, 1] = 5;
matrixSecond[0, 2] = 8;
matrixSecond[0, 3] = 5;
matrixSecond[1, 0] = 4;
matrixSecond[1, 1] = 9;
matrixSecond[1, 2] = 4;
matrixSecond[1, 3] = 2;
matrixSecond[2, 0] = 7;
matrixSecond[2, 1] = 2;
matrixSecond[2, 2] = 2;
matrixSecond[2, 3] = 6;
matrixSecond[3, 0] = 2;
matrixSecond[3, 1] = 3;
matrixSecond[3, 2] = 4;
matrixSecond[3, 3] = 8;

int[,] MatrixMultiplication(int[,] a, int[,] b)

{
    int[,] ab = new int[b.GetLength(0), a.GetLength(1)];
    if (a.GetLength(0) != b.GetLength(1))
    {
        Console.WriteLine("Нельзя перемножить эти матрицы");
        return ab;
    }
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int k = 0; k < b.GetLength(1); k++)
        {
            ab[i, k] = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                ab[i, k] =  ab[i, k] + a[i, j] * b[j, k];
            }
        }
    }
    return ab;
}

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

int[,] matrix = MatrixMultiplication(matrixFirst, matrixSecond);
PrintMatrix(matrixFirst);
Console.WriteLine();
PrintMatrix(matrixSecond);
Console.WriteLine();
PrintMatrix(matrix);