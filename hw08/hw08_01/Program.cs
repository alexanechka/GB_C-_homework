/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8 */

int[,] matrix = new int[3, 4];

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
// matrix[3, 0] = 2;
// matrix[3, 1] = 3;
// matrix[3, 2] = 8;
// matrix[3, 3] = 4;

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (k == j)
                {
                    continue;
                }
                if (matrix[i, j] > matrix[i, k])
                {
                    int value = matrix[i, k];
                    matrix[i, k] = matrix[i, j];
                    matrix[i, j] = value;
                }
            }

        }
    }
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

PrintMatrix(matrix);
SortMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);