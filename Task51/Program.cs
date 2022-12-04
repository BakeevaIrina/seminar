//Задача 51:
// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали 
//с индексами (0,0); (1;1) и т.д.

/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

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

int SummaDiagonal(int[,] matrix)
{
    int sum = default;
    for (int i = 0; i < matrix.GetLength(0); i++)//размер по rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//размер по colums
        {
          if(i == j ) sum += matrix[i,j];
          
       }
    }
    return sum;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int result = SummaDiagonal(array2D);
Console.WriteLine(result);



