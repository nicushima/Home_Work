Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int numlast = number / 10 % 10;
Console.WriteLine($"{number} -> {numlast}");