﻿// напишите программу которая выводит 
// случайное число из отрезка (10,99)
// Например 
// 78->8 
// 12->2
// 85->8

int num = new Random().Next(10, 100);
Console.WriteLine($"Было сгенерировано число {num}");
// Console.WriteLine("Было сгенерировано число " + num);
int num1 = num / 10;
int num2 = num % 10;
if (num1 > num2)
    Console.WriteLine($"Наибольшая цифра это {num1}");
else if (num1 < num2)
    Console.WriteLine($"Наибольшая цифра это {num2}");
else
    Console.WriteLine($"Обе цифры этого числа равны ");

for (int i = 1; i < num; i = i + 3)
    Console.Write($"{i}");