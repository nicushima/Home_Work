﻿//новая задача 
/*11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98 */

int number = new Random().Next(100, 1000);

int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"{number} -> {deleteSecondDigit}");

int DeleteSecondDigit(int num)
{
  int firstDigit = num / 100;
  int lastDigit = num % 10;
  int numResult = firstDigit * 10 + lastDigit;
  return numResult;
}
