/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

double GetPow(double number)
{
    return Math.Pow(number, 3);
}

double ReadNumber(string userString)
{
    Console.WriteLine(userString);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double userNumber = ReadNumber("Введите число");

for (double i = 1; i<= userNumber; i++)
{
    if (i>1) 
    {
        Console.Write(", ");
    }

    Console.Write(GetPow(i));
}
