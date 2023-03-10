// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadNumber(string userString)
{
    Console.WriteLine(userString);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int userNumber = ReadNumber("Введите пятизначное число");

int firstDigit = userNumber/10000;
// Console.WriteLine(firstDigit);
int secondDigit = userNumber/1000 % 10;
// Console.WriteLine(secondDigit);
int thirdDigit = userNumber/100 % 10;
// Console.WriteLine(thirdDigit);
int fourthDigit = userNumber/10 % 10;
// Console.WriteLine(fourthDigit);
int fifthDigit = userNumber % 10;
// Console.WriteLine(fifthDigit);

int palindrome = fifthDigit * 10000+ fourthDigit*1000 + thirdDigit * 100 + secondDigit * 10 + firstDigit;

if (palindrome == userNumber)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}
