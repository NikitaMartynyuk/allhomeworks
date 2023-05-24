// Задача 17 Напишите программу которая принимает на вход координаты точки (X и Y),
// причем х не= 0 и у не=0 и выдает номер четверти плоскости в которой находится эта точка  



// void CheckKoord(int x, int y)
// // {
// //     if (x > 0 && y > 0)
// //         System.Console.WriteLine("Четверть № 1");
// //     else if (x > 0 && y < 0)
// //         System.Console.WriteLine("Четверть № 4");
// //     else if (x < 0 && y < 0)
// //         System.Console.WriteLine("Четверть № 3");
// //     else if (x < 0 && y > 0)
// //         System.Console.WriteLine("Четверть № 2 ");
// //     else
// //         System.Console.WriteLine("Точка лежит на координатной оси");
// // }



// int CheckKoord2(int x, int y);
// {
//     int result = 0;
//     if (x > 0 && y > 0)
//         result = 1;
//     else if (x > 0 && y < 0)
//         result = 4;
//      else if (x < 0 && y < 0)
//         result = 3;
//      else if (x < 0 && y > 0)
//         result = 2;
//       return result ;
    
// }


// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x, y);
// System.Console.WriteLine(CheckKoord2(x,y));


// Задача 17 Напишите программу которая принимает на вход координаты точки (X и Y),
// причем х не= 0 и у не=0 и выдает номер четверти плоскости в которой находится эта точка  



 void CheckKoord(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Это четверть 1");
    else if (x > 0 && y < 0)
        Console.WriteLine("Это четверть 4");
    else if (x < 0 && y < 0)
        Console.WriteLine("Это четверть 3");
    else if (x > 0 && y > 0)
        Console.WriteLine("Это четверть 2");
    else
        Console.WriteLine("Эта точка лежит на координатной оси");
}

int CheckKoord2(int x, int y)
{
    int result = 0;
        if (x > 0 && y > 0)
        result = 1;
    else if (x > 0 && y < 0)
        result = 4;
    else if (x < 0 && y < 0)
        result = 3;
    else if (x > 0 && y > 0)
        result = 2;
    return result;
}

Console.WriteLine("Ведите координаты X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координаты Y");
int y = Convert.ToInt32(Console.ReadLine());
CheckKoord(x, y);
Console.WriteLine($" Это четверть {CheckKoord2(x, y)} ");
