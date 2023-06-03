
// // Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] arr = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

double[] avg = new double[arr.GetLength(1)];
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    avg[j] = sum / arr.GetLength(0);
    avg[j] = Math.Round(avg[j], 2);
}


Console.WriteLine("Среднее арифметическое каждого столбца: ");
foreach (double a in avg)
{
    Console.Write(a + "; ");
}