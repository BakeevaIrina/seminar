//Задача 66: 
//Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите промежуток от M до N через Enter: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());


int IntervalNumbers (int numM, int numN)
{
    if(numM < numN ) 
    { 
        numM = numM + IntervalNumbers(numM + 1, numN);
    }
    else if( numM > numN)
    {
        numM = numM + IntervalNumbers(numM - 1, numN);
    }

    return numM;

 
}


int res = IntervalNumbers(numberM,numberN);
Console.Write($"{res} ");
