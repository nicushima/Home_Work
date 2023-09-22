Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7)
{
    Console.WriteLine($"нет дня недели с таким номером");
}
else
{
    bool DayWeek(int num, int num1)
    {
       return num > num1;
    }

    bool result = DayWeek(number, 5);
    Console.Write(result ? $"{number}-> да" : $"{number} -> нет");
}

