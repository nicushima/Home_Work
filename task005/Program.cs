﻿// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool IsOneSquareOfTheOther(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

Console.WriteLine($"ввидите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"ввидите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsOneSquareOfTheOther(number1, number2);
Console.WriteLine(result ? "да" : "нет");