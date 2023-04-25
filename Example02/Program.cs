// Напишите программу,которая выводит случайное трехзначное число
//  и удаляет вторую цифру этого числа
// Например 
// 456->46
// 782->72

int num = new Random().Next(100, 1000);
Console.WriteLine($"Было сгенерировано число {num}");
int num1 = num / 100;
int num2 = num % 10;
Console.Write(num1);
Console.Write(num2);

