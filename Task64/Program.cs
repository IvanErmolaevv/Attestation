﻿//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System.Globalization;

int number(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);

    return num;
}

void sum(int numb)
{
    while (numb > 1)
    {
        Console.Write($"{numb}, ");
        numb -= 1;
    }
    Console.WriteLine("1");
}

sum(number("Введите число: "));