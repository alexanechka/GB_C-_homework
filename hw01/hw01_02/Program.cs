/* Задача 4: Напишите программу, которая принимает на вход
три числа и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int numberA;
int numberB;
int numberC;
int numberMax;

Console.WriteLine("Введите число a: ");
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
numberC = Convert.ToInt32(Console.ReadLine());

if (numberB > numberA) {
numberMax = numberB;
}
else
{
 numberMax = numberA;   
}

if (numberC > numberMax) {
numberMax = numberC;
}

Console.WriteLine("max = " + numberMax);