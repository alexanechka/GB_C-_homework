// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadUserInput(string userString)
{
    Console.WriteLine(userString);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int Power(int num, int pow)
{
    int res = num;
    int i = 1;
    while (i < pow)
    {
        res = num * res;
        i++;
    }
    return res;
}

int number = ReadUserInput("Введите число");
int power = ReadUserInput("Введите степень");

int result = Power(number, power);

Console.WriteLine(result);

