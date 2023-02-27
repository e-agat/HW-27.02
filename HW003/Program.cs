﻿/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());


void OuthutTableCube(int n)
{

    for (int i = 1; i <= n; i++)
    {
        Console.Write(Math.Pow(i, 3));
        Console.Write(i == n ? "." : ", ");
    }
}
OuthutTableCube(n);

