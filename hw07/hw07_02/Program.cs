/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
​1 4 7 2
5 9 2 3
​8 4 2 4
​1 7 -> такого числа в массиве нет */

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

int m = 5;
int n = 7;

int mElement = ReadUserInput("Введите номер строки ");
int nElement = ReadUserInput("Введите номер колонки ");

int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);

if (m >= mElement & n >= nElement)
{
    Console.WriteLine(matrix[mElement-1, nElement-1]);
}
else
{
    Console.WriteLine($"В массиве нет элемента [{mElement}, {nElement}]");
}