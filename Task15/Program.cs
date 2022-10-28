//Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет



Console.WriteLine("Введите число от 1 до 7: ");
string number = Console.ReadLine();


string Day(string num)
{
    if (num == "1") return "нет";
    if (num == "2") return "нет";
    if (num == "3") return "нет";
    if (num == "4") return "нет";
    if (num == "5") return "нет";
    if (num == "6") return "да";
    if (num == "7") return "да";

    return "Введены некоректные данные";
}

string result = Day(number);
Console.WriteLine(result);