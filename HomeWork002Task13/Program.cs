Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;

if (num < 100)
{
   Console.WriteLine($"третьей цифры нет ");
}
else
{

   while (num > 999)
   {
      num = num / 10;
   }

   num = num % 10 % 10;
   Console.WriteLine($"{number} -> {num}");
}

