// // Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int first_digit = num / 10000;
int second_digit = (num / 1000) % 10;
int fourth_digit = (num / 10) % 10;
int fifth_digit = num % 10;

if (first_digit == fifth_digit && second_digit == fourth_digit)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}