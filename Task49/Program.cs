//Задача 49: 
//Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, и 
//замените эти элементы на их квадраты.

//Изначальный массив:     Новый массив:
//1 4 7 2                   1 4 49 2
//5 9 2 3                   5 81 2 9
//8 4 2 4                   64 4 4 4

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)//строки и столбцы
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();//random - тип данных
    for (int i = 0; i < matrix.GetLength(0); i++)//размер по rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//размер по colums
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
        
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)//void тип данных, который не возвращает значения
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} ");
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine(" |");
    }
   
}

void ChangMatrixInt(int[,] matrix)//строки и столбцы
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)//размер по rows
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)//размер по colums
        //{
         // if(i % 2 == 0 && j % 2 == 0)  
          matrix[i, j] = matrix[i, j] * matrix[i, j];
       // }
        
    }
}

int[,] array2D = CreateMatrixRndInt(5, 5, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
ChangMatrixInt(array2D);
PrintMatrix(array2D);


