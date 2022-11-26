//Задача 36: 
//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();//random - тип данных
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)//void тип данных, который не возвращает значения
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int Multiplication(int[] array)
{
    int multi = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0) multi += array[i];
    }
    return multi;
}


int[] arr = CreateArrayRndInt(5, -10, 10);
PrintArray(arr);

int result = Multiplication(arr);
Console.WriteLine($"{result}");