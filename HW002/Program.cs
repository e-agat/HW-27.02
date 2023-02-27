/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();

Console.WriteLine("Введите координаты точки A: ");
Console.Write("X ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z ");
int bZ = Convert.ToInt32(Console.ReadLine());


double d = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2) + Math.Pow((bZ - aZ), 2));

Console.WriteLine($"Расстояние между точками А и В равно {Math.Round(d, 2)}");
