// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter start number: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Enter end number: ");
int n = int.Parse(Console.ReadLine()!);


int sum = SumNaturalNumbers(m, n);

Console.WriteLine("Sum of natural numbers from {0} to {1} is {2}", m, n, sum);
    

    static int SumNaturalNumbers(int m, int n)
{
    if (m == n) 
    {
        return m;
    }

    return m + SumNaturalNumbers(m + 1, n); }
