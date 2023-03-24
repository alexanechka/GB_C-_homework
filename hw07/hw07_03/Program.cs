/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
​
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

for (int i = 0; i < matrix.GetLength(0); i++)
{
    double average = 0;
    int columns = matrix.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
        average = matrix[j, i] + average;
    }
    average = average / columns;
    Console.WriteLine(average);
}