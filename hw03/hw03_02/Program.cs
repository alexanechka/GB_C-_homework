/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double ReadNumber(string userString)
{
    Console.WriteLine(userString);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double xa = ReadNumber("Введите координату точки A по X");
double ya = ReadNumber("Введите координату точки A по Y");
double za = ReadNumber("Введите координату точки A по Z");
double xb = ReadNumber("Введите координату точки B по X");
double yb = ReadNumber("Введите координату точки B по Y");
double zb = ReadNumber("Введите координату точки B по Z");

double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"{res:f2}");

