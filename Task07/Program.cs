Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
int lastDigit = number % 10;
Console.WriteLine($"Последняя чифра числа {lastDigit}");
}
else 
{
    Console.WriteLine($"введите трехзначное число!");
}