﻿//новая задача 
/*11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98 */

int number = new Random().Next(100, 1000);
int firstDigit = number / 100;
int lastDigit = number % 10;
int numResult = firstDigit * 10 + lastDigit;
Console.WriteLine($"{number} -> {numResult}");