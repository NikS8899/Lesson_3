// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// формула: AB = √(x1 - y1) ^ 2 + (x2 - y2) ^ 2 + (x3 - y3) ^ 2

Console.WriteLine("В порядке очереди (x 1; y 1; z 1) введите координаты точки A:");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В порядке очереди (x 2; y 2; z 2) введите координаты точки B:");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

var results = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
Console.WriteLine("Расстояние между точками: " + Math.Round(results));