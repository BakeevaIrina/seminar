Console.WriteLine("Введите точки");
Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Querter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int querter = Querter(x, y);
string result = querter > 0 //if
                 ? $"Указанные координаты соответствуют четверти -> {querter}" //? - тогда;
                 : "Введены не корректные координаты";//: - иначе
Console.WriteLine(result);