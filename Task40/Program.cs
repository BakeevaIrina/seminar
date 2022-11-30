//Задача 40:
// Напишите программу, которая 
//принимает на вход три числа и 
//проверяет, может ли существовать треугольник с сторонами такой длины.

Console.WriteLine("Введите три числа через Enter: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

bool IsExsistTriangle (int numA, int numB, int numC)
{
    bool b = numA < numB + numC && numB < numA + numC && numC < numA + numB;
    return b;
}

bool result = IsExsistTriangle(numberA, numberB, numberC);
Console.WriteLine(result);
