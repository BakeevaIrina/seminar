//Задача 31. 
///Задайте массив из 12 эл-ов, заполненый случайными числами из промежутка [-9,9]
//Найдите сумму отрицательных и положительных эл-ов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма полодительных чисел равна 29, 
//сумма отрицательных равна -20



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

int[] GetSumPositiveNegativeElem (int[] array)//создаем метод, тип данных мвссиы int[], 
                                             //передаем значения массива созданого выше
{//начало тела метода 
    int sumPositive = 0;//создаем переменнную для суммирования положительных чисел
    int sumNegative = 0;//переменная для суммы отрицательных чисел
    for (int i = 0; i < array.Length; i++)//открываем цикл
    {
        if (array[i] > 0) sumPositive += array[i];//условие: если эл-т массива > 0, то sumPositive + этот эл-т
        else sumNegative += array[i];//иначе
    }
    return new int[]{sumPositive, sumNegative};//возврращаем переменные 0 или 1
}




int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {getSumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {getSumPositiveNegativeElem[1]}");