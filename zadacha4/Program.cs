﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Напишите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Число " + numberA + " больше");
}
else if (numberA < numberB)
{
    Console.WriteLine("Число " + numberB + " больше");
}
else
{
    Console.WriteLine("Эти числа равны!");
}