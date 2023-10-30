using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main()
    {
        Console.WriteLine($"введите первое целое число");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"введите второе целое число");
        int n = Convert.ToInt32(Console.ReadLine());
        int result = Ackermann(m, n);
        Console.WriteLine("Ackermann(" + m + ", " + n + ") = " + result);
    }
}
