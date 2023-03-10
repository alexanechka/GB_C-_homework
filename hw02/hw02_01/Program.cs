/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int ReadNumber(string userString)
{
    Console.WriteLine(userString);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int userNumber = ReadNumber("Введите число");

Console.WriteLine(userNumber/10 % 10);