double FindDistance(int ax, int ay, int bx, int by)
{
    int leg1 = ax-bx;
    int leg2 = ay-by;
    double distance = Math.Sqrt((leg1 * leg1) + (leg2 * leg2));
    return distance;
}

Console.WriteLine("Введите координаты для точки A");
Console.Write("X : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y : ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B");
Console.Write("X : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y : ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(x1, y1, x2, y2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(result);