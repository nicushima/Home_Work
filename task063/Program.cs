﻿// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.WriteLine("ввидите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)
{
    Console.WriteLine("некоректный ввод");
    return;
}

void PrintNaturalNumbers(int num)
{
    if (num == 0) return;
    PrintNaturalNumbers(num - 1);
}