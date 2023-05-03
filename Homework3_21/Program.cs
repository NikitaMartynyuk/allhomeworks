// // Задача 21

// // Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84

// // A (7,-5, 0); B (1,-1,9) -> 11.53


double x1, y1, z1, x2, y2, z2;
Console.WriteLine("Введите координаты первой точки (x1 y1 z1):");
string[] coords1 = Console.ReadLine()!.Split(' ');
x1 = double.Parse(coords1[0]);
y1 = double.Parse(coords1[1]);
z1 = double.Parse(coords1[2]);

Console.WriteLine("Введите координаты второй точки (x2 y2 z2):");
string[] coords2 = Console.ReadLine()!.Split(' ');
x2 = double.Parse(coords2[0]);
y2 = double.Parse(coords2[1]);
z2 = double.Parse(coords2[2]);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками: {distance:F2}");
