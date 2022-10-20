Console.WriteLine("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());


bool Square( int numA, int numB)//method
{
    int result = numB * numB;
    if (result == numA) return true;
    return false;
}

bool result = Square(firstDigit, secondDigit);
if (result == true) Console.WriteLine($"Да");
else Console.WriteLine($"Нет");
