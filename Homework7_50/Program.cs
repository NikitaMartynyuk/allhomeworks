// // Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// //  и возвращает позицию этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:

// // 1 4 7 2

// // 5 9 2 3

// // 8 4 2 4

// // 17 -> такого числа в массиве нет


int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

Console.Write("Введите значение элемента: ");
int value = int.Parse(Console.ReadLine()!);

bool found = false;
int row = -1;
int column = -1;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] == value)
        {
            row = i;
            column = j;
            found = true;
            break;
        }
    }
    if (found)
    {
        break;
    }
}

if (found)
{
    Console.WriteLine($"Значение найдено в позиции [{row}, {column}]");
}
else
{
    Console.WriteLine("Такого значения в массиве нет");
}
