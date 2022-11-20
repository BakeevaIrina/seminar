//Задача 28
//Напишите программу, к-ая принимает на вход число N и
//выдает произведение чисел от 1 до N
//4 -> 24
//5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    int fac = 1;
    for (int i = 1; i <= num; i++)
    {
        //sum = sum + i;
        fac = fac * i;
    }
    return fac;
}

int result = Factorial(number);
Console.WriteLine(result);