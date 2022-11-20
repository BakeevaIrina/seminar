//Задача 26
//Напиште программу, к-ая принимает на вход число и
//выдает количество цифр в числе
//456 -> 3
//78 -> 2
//89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Digit(int num)
{
    num = Math.Abs(num);//ставит число по модулю
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count ++;
    }
    return count > 0 ? count : 1;
}

int result = Digit(number);
Console.WriteLine(result);