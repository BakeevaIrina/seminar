//Задача 1. Вывести квадрат целого числа

Console.WriteLine("Введите целое число: ");//текст для пользователя
int number = Convert.ToInt32(Console.ReadLine());//считываем и конвертируем данные с консоли в целочисленный тип

int souare = number * number;//ищем квадрат
Console.WriteLine($"Квадрат числа {number} = {souare} ");//вывод результата 