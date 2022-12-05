//Задача 55: 
//Задайте двумерный массив. Напишите программу, которая 
//заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.

int[,] CreateMatrixRndInt (int rows, int colums, int min, int max)
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
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine(" |");
    }
}

int[,] ReplaceRowsToColums (int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           newMatrix[i,j] = matrix[j,i];
        }
    }
    return newMatrix;
}

int[,] array = CreateMatrixRndInt(4, 4, 0, 9);
if(array.GetLength(0) == array.GetLength(1))
{
    PrintMatrix(array);
    Console.WriteLine();
    int [,] arr = ReplaceRowsToColums(array);
    PrintMatrix(arr);
}
else Console.WriteLine("Невозможно заменить строки на столбцы!");