Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());


string Querter(int num)
{
    if (num == 1) return "x>0, y>0";
    if (num == 2) return "x<0, y>0";
    if (num == 3) return "x<0, y<0";
    if (num == 4) return "x>0, y<0";

    return "Введен неверный носер четверти";
}

Console.WriteLine(Querter(quarter));