//Задача 1. Вывести квадрат целого числа
/*Console.WriteLine("Введите целое число: ");//текст для пользователя
int number = Convert.ToInt32(Console.ReadLine());//считываем и конвертируем данные с консоли в целочисленный тип

int souare = number * number;//ищем квадрат
Console.WriteLine($"Квадрат числа {number} = {souare} ");//вывод результата 
*/

//Задача 2. 
Console.WriteLine("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int souare = numberB * numberB;

if (numberA == souare)
{
 Console.WriteLine($"Число a = {numberA} явлется квадратом {souare} числа b = {numberB} ");   
}
else 
{
    Console.WriteLine($"Число a {numberA} НЕ явлется квадратом числа b = {numberB} ");   
}