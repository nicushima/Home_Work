
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int count = 1;
    
    if (number < 2)
        {
            Console.WriteLine($"нет четных чисел");
        }

       Console.Write($"{number} -> ");

    while (count <= number)
    {

        if (count % 2 == 0)
        {
            Console.Write($"{count}, ");
            count++;
        }
        else
        {
            count++;
        }

    }
}

