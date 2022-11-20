/*double d = Math.Sqrt(45);
double res = Math.Round(d, 2, MidpointRounding, ToZero);//округление
Console.WriteLine(res);

Math.Sqrt(45);//корень числа 

//Задача 20: Напшите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит растояния между ними в 2D пространстве 

// A(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21
/*
Console.WriteLine("Введите координату A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
*/
//Задача 23
// 1. Напишите программу, которая принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.
/*
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125 */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = 0;

if (number > 0)
{
    int count = 1;
    while (digit<number)
}

{
    int quare = digit * digit;
    Console.WriteLine($"{number}");
    Console.WriteLine($"{digit} | {quare}");

    return digit++;
}
 return 0;
