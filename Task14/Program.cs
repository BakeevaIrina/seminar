Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberA = 7;
int numberB = 23;

bool Multiple(int digit, int numA, int numB)//method
{
    int result1 = digit % numA;
    int result2 = digit % numB;
    if (result1 == 0 && result2 == 0) return true;
    return false;
}

bool result = Multiple (number, numberA, numberB);
if (result == true) Console.WriteLine($"Кратное");
else Console.WriteLine($"НЕ кратное");
