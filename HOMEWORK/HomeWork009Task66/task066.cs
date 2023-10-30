// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumRec(int a, int b)
{
    if (a == b) return b;
    else return a + SumRec(a - 1, b);
}

Console.WriteLine($"ввидите первое натуральное число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"ввидите второе натуральное число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumRec(M, N));


