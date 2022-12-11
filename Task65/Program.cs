//Задача 65:
// Задайте значения M и N. Напишите программу, которая
//выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите промежуток от M до N через enter: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());


void IntervalNumbers (int numM, int numN)
{
    if(numM < numN )
    {
        Console.Write($"{numM} ");
        IntervalNumbers(numM + 1, numN);
        //Console.Write($"{numN} ");
    }
    if (numM > numN)
    {
        Console.Write($"{numM} ");
        IntervalNumbers(numM - 1, numN); 
    }
    if (numM == numN)
    {
        Console.Write($"{numM} ");
    }
    
}


IntervalNumbers(numberM,numberN);
