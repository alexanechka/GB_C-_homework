// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

/* функция ack(n, m)
   если n = 0
     вернуть m + 1
   иначе, если m = 0
     вернуть ack (n - 1, 1)
   еще
     вернуть ack(n - 1, ack (n, m - 1)) */

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Ack(n - 1, 1);
    return Ack(n - 1, Ack(n, m - 1));
}

Console.WriteLine(Ack(2, 3));

Console.WriteLine(Ack(3, 2));