//Задача 27: Напишите программу, которая 
//принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int digit = 0;
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        digit = num % 10;
        sum =  sum + digit;
        num = num / 10;
    }
    return sum;
}

int result = Sum(number);
Console.WriteLine($"{number} -> {result}");