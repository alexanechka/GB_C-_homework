﻿
// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

int numberA;
int numberB;
Console.WriteLine("Введите число a: ");
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > numberA) {
Console.WriteLine("max = " + numberB + ", min = " + numberA);
}
else
{
 Console.WriteLine("max = " + numberA + ", min = " + numberB);   
}
