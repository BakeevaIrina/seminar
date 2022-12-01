//Задача 45:
// Напишите программу, которая будет 
//создавать копию заданного массива с помощью поэлементного копирования.

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

int[] CopyArray (int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void PrintArray (int[] array)//void тип данных, который не возвращает значения
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
int[] newArr = CopyArray(arr);
PrintArray(newArr);
