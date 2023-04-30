// Задача 17 Напишите программу которая принимает на вход координаты точки (X и Y),
// причем х не= 0 и у не=0 и выдает номер четверти плоскости в которой находится эта точка  

Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());



void CheckKoord(int x, int y )
{
   if (x > 0 && y > 0)
       System.Console.WriteLine("Четверть № 1");
     else if (x > 0 && y < 0)
     System.Console.WriteLine("Четверть № 4");
     else if (x < 0 && y < 0)
     System.Console.WriteLine("Четверть № 3");
     else if (x < 0 && y > 0)
     System.Console.WriteLine("Четверть № 2 ");
     else 
     System.Console.WriteLine("Точка лежит на координатной оси");    
}