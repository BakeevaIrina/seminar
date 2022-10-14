Console.WriteLine("Введите чило a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB)
{
    Console.Write($" min = {numberA}, max = {numberB} ");

}
else
{
    Console.Write($" min = {numberB}, max = {numberA}");
}