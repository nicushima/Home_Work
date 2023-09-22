Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int number3 = Convert.ToInt32(Console.ReadLine());

int intermediate = number1;

if (number2 > intermediate)
{
   intermediate = number2;
}
if (number3 > intermediate)
{
   intermediate = number3;
}
Console.WriteLine($"{number1},{number2},{number3} -> {intermediate}");