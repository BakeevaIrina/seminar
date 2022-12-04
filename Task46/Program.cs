﻿//Задача 46: 
//Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами.
//m = 3, n = 4.
//  1   4   8   19
//  5   -2  33  -2
//  77  3   8   1

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

int[,] array2D = CreateMatrixRndInt(3, 4, -1000, 1000);
PrintMatrix(array2D);