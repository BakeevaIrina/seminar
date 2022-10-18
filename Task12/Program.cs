Console.WriteLine("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());




if (numberA % numberB == 0) Console.WriteLine($"Кратное!");

else  Console.WriteLine($"Не кратное, остаток - {numberA % numberB}");
