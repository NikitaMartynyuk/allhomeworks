// // Напишите программу которая будет принимать на вход два числа
// // и выводить,является ли второе число кратным первому.Если число
//  2 не кратно числу 1,то программа выводит остаток от деления
// Например
// 34,5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int div = num1 % num2;
if (div == 0)
    Console.WriteLine("Число кратно");
else
{
    Console.WriteLine($"Число не кратно, остаток от деления =  {div}");
}
