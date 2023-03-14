// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadUserInput(string userString)
{
    Console.WriteLine(userString);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int SumDigit(int num)
{
    int num_to_parce = num;
    int sum = 0;
    while (num_to_parce > 0)
    {
        sum = sum + num_to_parce % 10;
        num_to_parce = num_to_parce / 10;
    }
    return sum;
}

int number = ReadUserInput("Введите число ");
int summ = SumDigit(number);
Console.WriteLine(summ);