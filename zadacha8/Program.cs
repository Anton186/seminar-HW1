﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Напишите число :");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (numberA < 1)
{
    Console.WriteLine("Тут нету четных чисел");
}
while (count < numberA -3)
{
    count = count + 2;
    Console.Write(count + ", ");
}

