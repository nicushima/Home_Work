﻿// Задача 43: Напишите программу,
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("ввидите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввидите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввидите b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввидите k2");
double k2 = Convert.ToInt32(Console.ReadLine());
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x};{y})");

