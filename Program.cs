﻿Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"xисло: {number} - палиндром.");
    }
    else Console.WriteLine($" число: {number} - Не палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");
