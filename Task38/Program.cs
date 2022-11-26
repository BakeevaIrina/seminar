//Задача 38
// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArayRndDouble (int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num =rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray (double[] array)//void тип данных, который не возвращает значения
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},  ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DifferenceNumbers(double[] array)
{
    double max = 0;
    double min = array.Length;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];

    }
    return max - min;    
}

double[] arr = CreateArayRndDouble(5, -9.9, 9.9);
PrintArray(arr);

double result = DifferenceNumbers(arr);
Console.WriteLine($"{result}");