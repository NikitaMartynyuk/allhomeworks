// Задача 54:Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] arr = new int[,]
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};

int m = arr.GetLength(0); 
int n = arr.GetLength(1); 

for (int i = 0; i < m; i++)
{
    for (int j = 1; j < n; j++)
    {
        int key = arr[i, j];
        int k = j - 1;

        
        while (k >= 0 && arr[i, k] < key)
        {
            arr[i, k + 1] = arr[i, k];
            k--;
        }

        arr[i, k + 1] = key;
    }
}


for (int i = 0; i < m; i++)

    for (int j = 0; j < n; j++)
    {
        Console.Write("{0} ", arr[i, j]);
    }

    Console.WriteLine();