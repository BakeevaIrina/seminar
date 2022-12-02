//Задача 43: 
//Напишите программу, которая 
//найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1:");
double numberB1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1:");
double numberK1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2:");
double numberB2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2:");
double numberK2 = Convert.ToInt32(Console.ReadLine());

double[] ArrayPoint (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}

void PrintArray (double[] array)//void тип данных, который не возвращает значения
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


double[] arr = ArrayPoint(numberB1, numberK1, numberB2,  numberK2);
PrintArray(arr);