// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Напишите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Число " + numberA + " больше");
    Console.WriteLine("Число " + numberB + " меньше");
}
else 
{
    Console.WriteLine("Число " + numberA + " меньше");
    Console.WriteLine("Число " + numberB + " больше");
}
