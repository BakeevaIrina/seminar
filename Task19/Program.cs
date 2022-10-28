//Задача 19
//Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
//2. проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int num)
{
    int integer = num / 1000; //23
    int even = num % 100;//32
    int res = integer - even;
    return res == 9 || res == -9 ? true : false;
}

bool result = Palindrome(number);
if (result == true) Console.WriteLine("Да");
else Console.WriteLine("Нет");