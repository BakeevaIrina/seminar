﻿Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int even = number % 2;

if (even == 0)
{
    Console.Write($"{number} - четное ");
}
else
{
    Console.Write($"{number} - нечетное ");
}