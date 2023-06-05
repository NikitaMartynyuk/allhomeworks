// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];
int num = 1;
int topRow = 0, bottomRow = 3, leftCol = 0, rightCol = 3;

while (topRow <= bottomRow && leftCol <= rightCol)
{

    for (int i = leftCol; i <= rightCol; i++)
    {
        array[topRow, i] = num++;
    }
    topRow++;


    for (int i = topRow; i <= bottomRow; i++)
    {
        array[i, rightCol] = num++;
    }
    rightCol--;


    for (int i = rightCol; i >= leftCol; i--)
    {
        array[bottomRow, i] = num++;
    }
    bottomRow--;


    for (int i = bottomRow; i >= topRow; i--)
    {
        array[i, leftCol] = num++;
    }
    leftCol++;
}


for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0:D2} ", array[i, j]);
    }
    Console.WriteLine();
}