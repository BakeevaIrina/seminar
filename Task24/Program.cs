//Задача 24
//Напишите программу, к-ая принимает на вход число (А) и 
//выдает сумму чисел от 1 до А
//7 -> 28
//4 -> 10 
//8 -> 36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}
int result1 = SumNumbers(35);
int result2 = SumNumbers(345);

int result = SumNumbers(number);
Console.WriteLine(result);
Console.WriteLine(result1);
Console.WriteLine(result2);