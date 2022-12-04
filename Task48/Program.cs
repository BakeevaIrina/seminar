//Задача 48: 
//Задайте двумерный массив размера m на n,
//каждый элемент в массиве находится по формуле: Amn = m+n.
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

int[,] CreateMatrixRndInt(int rows, int colums)//строки и столбцы
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)//размер по rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//размер по colums
        {
            matrix[i, j] = i + j;
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
            Console.Write("{0, 4} ", matrix[i, j]);
        }
        Console.WriteLine(" |");
    }
   
}

int[,] array2D = CreateMatrixRndInt(3, 4);
PrintMatrix(array2D);