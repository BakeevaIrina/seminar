//Задача 41:
// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 

Console.WriteLine("Введите количество чисел для ввода: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    //Random rnd = new Random();//random - тип данных
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Число: ");
        int number = Convert.ToInt32(Console.ReadLine()); 
        array[i] = number;

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

int Sum (int[] array)
{
    int sum = default;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) sum ++;
    }
    return sum;
}

int[] arr = CreateArrayRndInt(size);
PrintArray(arr);
 
int result = Sum(arr);
Console.Write($"Количество чисел больше 0 -> {result}");
