//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using System.Globalization;

int number(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);

    return num;
}

void sum(int numbA, int numbB)
{
    int summ = 0;
    while (numbA <= numbB)
    {
        summ += numbA;
        numbA += 1;
    }
    Console.WriteLine(summ);
}

sum(number("Введите первое число: "), number("Введите второе число: "));