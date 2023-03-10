/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число");
string userString = Console.ReadLine();
int digits = userString.Length;

if (digits > 2)
{
    Console.WriteLine(Math.Truncate(Convert.ToInt32(userString) / Math.Pow(10, digits - 3) % 10));
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
    