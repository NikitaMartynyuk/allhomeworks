// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет,
//  является ли оно палиндромом. Через строку нельзя решать само собой. 

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

bool isPalindrome = IsPalindrome(number);

if (isPalindrome)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}


static bool IsPalindrome(int number)
{
    string strNumber = number.ToString();
    int length = strNumber.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (strNumber[i] != strNumber[length - i - 1])
        {
            return false;
        }
    }

    return true;
}
