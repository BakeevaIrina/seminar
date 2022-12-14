//Задача 42: 
//Напишите программу, которая будет 
//преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Transformation (int num)
{
    int result = default;
    while (num > 0)
    {
        int digit = num % 2;
        result += digit;
        result *= 10;
        num /= 2;
        
    }
    return result;
}

int RevertNumber (int par)
{
    int result = 0;
    while (par > 9)
    {
        result += par % 10;
        result *= 10;
        par /= 10;
    }
    result += par % 10;
    return result;
}
/*
int transformation = Transformation(number);
Console.WriteLine($"{number} -> {transformation}");*/

Console.WriteLine(RevertNumber(Transformation(number)));