//Задача 30 
//Напишите программу, к-ая выводит массив из 8 элементов, заполненый 0 и 1 в случайном порядке
//[0,1,1,0,1,0,0,1]

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] NameArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

int[] result = NameArray(num);
PrintArray(result);