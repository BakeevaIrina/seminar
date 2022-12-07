//Задача 56: 
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.
//Например, задан массив:

//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7

//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatriaRndInt (int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 5}");
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("   |");
    }
}

int[] SummaElementsRows (int[,] matrix)
{
    int count = 0;
    int sum = 0;
    int[] newArray = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < j + 1 && i == count)sum += matrix[i, j];
        } 
        newArray[i] = sum;
        count ++;
    }
    return newArray;
}

void CheckMinSummaRows (int[] newArray)
{
    int elem = newArray[0];//23 -> 22
    int row = 1;
    for (int i = 0; i < newArray.Length; i++)//21
    {
        if(newArray[i] < elem)  
        {
            elem = newArray[i];
            row = i + 1;
        }
        

    }
    Console.WriteLine($"Наименьшая сумма находится в {row} строке ");
}


int[,] array = CreateMatriaRndInt(3, 5, 1, 9);
PrintMatrix(array);
Console.WriteLine();
int[] arr = SummaElementsRows(array);
CheckMinSummaRows(arr);