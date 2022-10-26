//Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int Digit (int num)
{
    if (num < 100)
    return 0;
    else while (num >= 1000) num= num / 10;
    int even = num % 10;
    return even;   
}

int result = Digit(number);
if (result == 0) Console.WriteLine("Третьей цифры нет!");
else Console.WriteLine(result);
