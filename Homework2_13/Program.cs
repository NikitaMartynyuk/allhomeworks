// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Получаем третью цифру числа
        int thirdDigit = (number / 1) % 10;
        
        if (thirdDigit == -1)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
        {
            
            Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}");
        }
        
