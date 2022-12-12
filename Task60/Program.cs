//Задача 60. 
//...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
//будет построчно выводить массив, добавляя индексы каждого элемента.
//Например, задан массив размером 2 x 2 x 2.
//Результат:
//66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
//34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix3D(int rows, int colums, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, colums, depth];
    int temp = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = temp++;
                
                
            }

        }
    }

    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        string strTab = "";
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            string str = "";
            //Console.Write("");
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.Write($"{matrix[i, j, k],5 } [{i},{j},{k}]");
                //else  Console.Write($"{matrix[i, j, k],5} [{i},{j},{k}]");
            }
            Console.WriteLine(strTab + str);// Строка в глубину
                strTab += "   ";  
        }
        //Console.WriteLine("   ");
    }
}

int[,,] matrix3D = CreateMatrix3D(2, 2, 2, 1, 9);
PrintMatrix3D(matrix3D);
