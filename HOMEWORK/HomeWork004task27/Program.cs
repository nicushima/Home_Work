// Задача 27: Напишите программу,
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumOfDigitsInNumber(int num)
{
   int num1 = num % 10;
   int num2 = num / 10 % 10;
   int num3 = num / 100;
   int sum = num1 + num2 + num3;
   return sum;
}


Console.WriteLine("ввидите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfDigitsInNumber = SumOfDigitsInNumber(number);
Console.WriteLine($"{number} -> {sumOfDigitsInNumber}");