Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = 1;
    while (count <= number)
    {
        int even = count % 2;
        if (even == 0)
        {
            Console.Write($"{count} ");
        
        }
                
        count++;
        
    }

}

else
{
    Console.Write("Введите целое положительное число");
}