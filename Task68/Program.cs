//Задача 68: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите положительное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int AkkermanFoction (int numM, int numN)
{
    if(numM == 0) return numN + 1;
    if(numN == 0 ) return AkkermanFoction(numM - 1, 1);
    return AkkermanFoction(numM -1, AkkermanFoction(numM, numN -1));
}

int result = AkkermanFoction(numberM, numberN);
Console.WriteLine(result);