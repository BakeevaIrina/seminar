//Задача 67:
// Напишите программу, которая будет принимать на вход число и
//возвращать сумму его цифр.
//453 -> 12
//45 -> 9

Console.WriteLine("Введите натурально число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumElementsNumber (int num)
{
    if(num == 0) return num;
    return num % 10 + SumElementsNumber(num / 10);
}

int result = SumElementsNumber(number);
Console.WriteLine(result);