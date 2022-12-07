//Задача 54: 
//Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:       В итоге получается вот такой массив:
//  1 4 7 2                     7 4 2 1
//  5 9 2 3                     9 5 3 2
//  8 4 2 4                     8 4 4 2

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

void PrintMatrrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("   |");
    }

}

void SortElementsRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)//0
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)//1
        {
            if (matrix[i, j] > matrix[i, j + 1])
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, j + 1];
                matrix[i, j + 1] = temp;

            }
        }
    }
}

int[,] array = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrrix(array);
Console.WriteLine();
SortElementsRows(array);
PrintMatrrix(array);
