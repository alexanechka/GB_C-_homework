/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] GetArray(int lenthArray)
{
    double[] arr = new double[lenthArray];
    for (int i = 0; i < lenthArray; i++)
    {
        arr[i] = Random.Shared.NextDouble();
    }
    return arr;
}

void PrintArray(double[] array)
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

double DeltaMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
}

double[] randArray = GetArray(4);
PrintArray(randArray);
Console.WriteLine(DeltaMaxMin(randArray));