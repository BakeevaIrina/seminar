//Задача 39:
// Напишите программу, которая перевернет одномерный массив

//[1 2 3 4 5] -> [5 4 3 2 1]

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
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// 0 1 2 3 4      0 1 2 3 4
//[1 2 3 4 5] -> [5 4 3 2 1]
void ReverseArray (int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];//1
        array[i] = array[array.Length - 1 - i];//5 последний элемент
        array[array.Length - 1 - i] = temp;
    }
}


int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
Array.Reverse(arr);//перевернутый массив
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);