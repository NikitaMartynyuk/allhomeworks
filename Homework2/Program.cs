﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное
//  число и на выходе показывает вторую цифру этого числа. 
// Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int secondDigit = (number / 10) % 10;

    Console.WriteLine("Вторая цифра числа: " + secondDigit);
  
