//Задача 10: Напишите программу, которая 
//1. принимает на вход трёхзначное число и 
//2. на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Div(int num)
{
    int firstDigit = num / 10;
    return firstDigit % 10;
}

int result = Div(number);
Console.WriteLine(result);

