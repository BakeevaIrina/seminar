int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное = {number}");


//решаем методом
int Digit (int num)//method
{
    int firstDigit = num / 100 *10; // 784/100=7
    int secondDigit = num % 10; // 784%10=4
    return firstDigit + secondDigit;//тернарный оператор
}
int digit = Digit(number);
Console.WriteLine($"Наибольшая цифра числа {number} равна {digit}");
