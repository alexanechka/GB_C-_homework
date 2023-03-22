/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
 */

int[] GetArray(int lenthArray)
{
    int[] arr = new int[lenthArray];
    for (int i = 0; i < lenthArray; i++)
    {
        arr[i] = Random.Shared.Next(100, 1000);
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
    Console.WriteLine("]");
}

int EvenCount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

int[] randArray = GetArray(4);
PrintArray(randArray);
Console.WriteLine(EvenCount(randArray));