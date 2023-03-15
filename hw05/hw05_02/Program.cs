/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GetArray(int lenthArray)
{
    int[] arr = new int[lenthArray];
    for (int i = 0; i < lenthArray; i++)
    {
        arr[i] = Random.Shared.Next(-100, 100);
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

int OddPositionCount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            result = result + array[i];
        }
    }
    return result;
}

int[] randArray = GetArray(4);
PrintArray(randArray);
Console.WriteLine(OddPositionCount(randArray));

