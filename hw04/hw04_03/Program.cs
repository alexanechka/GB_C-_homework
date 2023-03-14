/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] GetArray()
{
    int[] arr = new int[8];
    for (int i = 0; i< 8; i++)
    {
        arr[i] = Random.Shared.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i > 0)
        {
            Console.Write(", ");  
        }
        Console.Write(array[i]);  
    }
    Console.Write("]");
}

int[] randArray = GetArray();
PrintArray(randArray);