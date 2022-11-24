//Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

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

bool Find(int[] array, int find1)
{
    bool b = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find1)
        {
            b = true;
            break;
        }
    }
    return b;
}

int[] array = CreateArrayRndInt(10, 0, 4);
PrintArray(array);

Console.WriteLine("Введите число: ");
int elem = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Find(array, elem) ? "Да" : "Нет");