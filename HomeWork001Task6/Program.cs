Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)
{
    Console.WriteLine($"{number} -> нет");
}
else
{
    Console.WriteLine($"{number} -> да");
}