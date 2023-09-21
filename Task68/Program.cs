//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

using System.Globalization;

int number(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);

    return num;
}

int ack(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else if (n == 0 && m > 0)
    {
        return ack(m - 1, 1);
    }
    else
    {
        return ack(m - 1, ack(m, n - 1));
    }
}

Console.WriteLine(ack(number("Введите первое число: "), number("Введите второе число: ")));