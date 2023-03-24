/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
​
m = 3, n = 4.​
0,5 7 -2 -0,2​
1 -3,3 8 -9,9​
8 7,8 -7,1 9 */

int ReadUserInput(string userString)
{
    Console.WriteLine(userString);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Random.Shared.Next(-150, 150);//int.MinValue, int.MaxValue);
        }
    }
    return matrix;
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


int m = ReadUserInput("Введите число строк ");
int n = ReadUserInput("Введите число колонок ");

int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);