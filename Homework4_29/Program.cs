// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] arr1 = {1, 2, 5, 7, 19};
int[] arr2 = {6, 1, 33};

Console.Write("[");
for (int i = 0; i < arr1.Length; i++)
{
    Console.Write(arr1[i]);
    if (i < arr1.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");

Console.Write("[");
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i]);
    if (i < arr2.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");