//Задача 58: 
//Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:     Результирующая матрица будет:
//2 4 | 3 4                     18 20
//3 2 | 3 3                     15 18
int[,] CreateMarrixOne (int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
}

int[,] CreateMarrixTwo (int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max +1);
        }
    }
    return array;
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

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j < array.GetLength(1) -1) Console.Write($"{array[j, j], 5}");
            else Console.Write($"{array[j, j], 5}");
        }
        Console.WriteLine("   |");
    }
}

int[,] ArrayResult (int[,] matrix, int[,] array)
{
    int[,] arrayResult = new int[matrix.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < arrayResult.GetLength(0); i++)
    {
        
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {
            int multiply = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                multiply += matrix[i,k]*array[k,j];
            }
            arrayResult[i,j]=multiply;
    }
            //arrayResult[i, j] = matrix[i, k] * array[i, j] + matrix[i, j + 1] * array[i, j + 1];
        }
        
    return arrayResult;
}
 
void PrintArrayRes (int[,] arrayResult)
{
    for (int i = 0; i < arrayResult.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {
            if(j < arrayResult.GetLength(1) -1) Console.Write($"{arrayResult[i, j], 5}");
            else Console.Write($"{arrayResult[i, j], 5}");
        }
        Console.WriteLine("   |");
    }
}

int[,] arr = CreateMarrixOne(2, 2, 1, 9);
PrintMatrix(arr); 
Console.WriteLine();
Console.WriteLine("     x");
Console.WriteLine();
int[,] newArr = CreateMarrixTwo(2, 2, 1, 9);
PrintArray(newArr);
Console.WriteLine();
if(arr.GetLength(1) != newArr.GetLength(0)) Console.WriteLine("число столбцов матрицы P Не равняется числу строк матрицы K.");
else
{
    int[,] arrRes = ArrayResult(arr, newArr);
    PrintArrayRes(arrRes);
}