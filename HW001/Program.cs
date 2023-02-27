/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");

int i = int.Parse(Console.ReadLine());

int firstNum = i / 10000;
int secondNum = i / 1000 % 10;
int fourNum = i / 10 % 10;
int fiveNum = i % 10;

if (firstNum == fiveNum && secondNum == fourNum)
{
    Console.WriteLine($"Число {i} является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}




