/* Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

int numberA;
string answer;

Console.WriteLine("Введите число a: ");
numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0)
{
answer = "четное";
}
else
{
  answer = "нечетное";  
}

Console.WriteLine(answer);
