﻿
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"a = {number1}; b = {number2}; max = {number1}");
}
else if (number1 < number2)
{
   Console.WriteLine($"a = {number1}; b = {number2}; max = {number2}");
}
else 
{
    Console.WriteLine($"a = {number1}; b = {number2}; a = b");
}
