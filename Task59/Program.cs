//Задача 59: 
//Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:      Наименьший элемент - 1, на выходе 
//  1 4 7 2                          получим следующий массив:
//  5 9 2 3                                 9 2 3
//  8 4 2 4                                 4 2 4
//  5 2 6 7                                 2 6 7

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int[] IndexMinElement(int[,] matrix)
{
    int horizont = 0;
    int vertical = 0;
    int min = matrix[horizont, vertical];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                horizont = i;
                vertical = j;
            }
        }
    }
    return new int[] {horizont, vertical};
}
void PrintArray(int[] array)//void тип данных, который не возвращает значения
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[,] NewArray(int[,] matrix, int m, int n)
{
    int[,] newArray = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int countHor = 0;
    int countVer = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        if (countHor == m) countHor++;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (countVer == n) countVer++;
            {
                newArray[i, j] = matrix[countHor, countVer];
            }
            countVer++;
        }
        countVer = 0;
        countHor++;
    }
    return newArray; 
}

int[,] array = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(array);
int[] index = IndexMinElement(array);
PrintArray(index);
int[,] newArr = NewArray(array, index[0], index[1]);
PrintMatrix(newArr);



