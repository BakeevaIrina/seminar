//9. Напишите программу, которая
//1. выводит случайное число из отрезка (10, 99)
//2. показывает наибольшую цифру числа

//78->8
//12->2
//85->8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 = {number}");
/*
int firstDigit = number / 10; // 78/10=7
int secondDigit = number % 10; // 78%10=8*/
//1
//if (firstDigit > secondDigit) System.Console.WriteLine($"Наибольшая цифра числa = {firstDigit}");
//else Console.WriteLine($"Наибольшая цифра числa = {secondDigit} ");

//АНАЛОГ1
//int res = Math.Max(firstDigit, secondDigit);
//Console.WriteLine(res);
/*
//Условный оператор
int result = default;//значение по умолчанию, для int это 0, пишем для удобства, значение не определено 
if (firstDigit > secondDigit) result = firstDigit;
else result = secondDigit;
Console.WriteLine($"Наибольшая цифра числa = {result} ");

//Тернарный оператор 1
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; //если firstDigit больше secondDigit тогда в переменную maxDigit записываем переменную firstDigit иначе secondDigit
Console.WriteLine($"Наибольшая цифра числa = {maxDigit} ");

//Тернарный оператор 2
Console.Write($"Наибольшая цифра числa {number} равна  ");
Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);*/


//решаем методом
int MaxDigit (int num)//method
{
    int firstDigit = num / 10; // 78/10=7
    int secondDigit = num % 10; // 78%10=8
    return firstDigit > secondDigit ? firstDigit : secondDigit;//тернарный оператор
}
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");
