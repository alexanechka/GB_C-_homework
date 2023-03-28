/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void Print1ToN(int n)
{
    if (n < 1) return;

    Console.Write($"{n} ");
    Print1ToN(n - 1);
}

int number = 5;
Print1ToN(number);

Console.WriteLine();
number = 8;
Print1ToN(number);

