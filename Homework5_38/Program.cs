// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

double[] numbers = { 3.14, 2.71, 1.618, 0.707, 2.718 };

double min = double.MaxValue;
double max = double.MinValue;

// Найдём минимальный и максимальный элементы массива
foreach (double number in numbers)
{
    if (number < min)
        min = number;

    if (number > max)
        max = number;
}

double difference = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");