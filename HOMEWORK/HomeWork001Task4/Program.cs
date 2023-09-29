Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
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