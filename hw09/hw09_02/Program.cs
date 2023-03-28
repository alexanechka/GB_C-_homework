/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


int SumOfNumbersBetweenMAndN(int m, int n)
{
    if (m == n) return m;
    if (n < m) return SumOfNumbersBetweenMAndN(n, m);
    return n + SumOfNumbersBetweenMAndN(m, n - 1);
}

Console.WriteLine(SumOfNumbersBetweenMAndN(1, 15));
Console.WriteLine(SumOfNumbersBetweenMAndN(15, 1));
Console.WriteLine(SumOfNumbersBetweenMAndN(4, 8));
Console.WriteLine(SumOfNumbersBetweenMAndN(8, 8));