﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Напишите число :");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (numberA < 2)
{
    Console.WriteLine("Тут нету четных чисел");
}
else
{
    while (count < numberA -3)
    {
        count = count + 2;
        Console.Write(count + ", ");
    }
    if (count < numberA)
    {
        Console.WriteLine(count + 2 + ".");
    }
}
