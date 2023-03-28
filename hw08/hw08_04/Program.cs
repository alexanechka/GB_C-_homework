/* 
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)

 */

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k > 0)
                {
                    Console.Write(" ");
                }
                Console.Write(matrix[i, j, k] + $" ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int num = 1;
int[,,] matrix = new int[2, 2, 2];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
            matrix[i, j, k] = num++;
    }
}

PrintMatrix(matrix);
