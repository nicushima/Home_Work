/*9. Напишите программу, которая выводит
1. случайное число из отрезка [10, 99] и показывает
2. наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 
*/

int number = new Random().Next(10, 100); // 99 + 1
Console.WriteLine($"случайное число -> {number}");

//int firstDidit = number / 10; // 78 / 10 = 7
//int secontDigit = number % 10;

//if (firstDidit > secontDigit) Console.WriteLine($"наибольшее число -> {firstDidit}");
//else Console.WriteLine($"наибольшее число -> {secontDigit}");

//int maxDigit = firstDidit > secontDigit ? firstDidit : secontDigit; // тернанрный оператор  if и else
//Console.WriteLine($"наибольшее число -> {maxDigit}");

int MaxDigit = MaxDigit(number);
Console.WriteLine($"наибольшее число -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDidit = num / 10;
    int secontDigit = num % 10;
    return firstDidit > secontDigit ? firstDidit : secontDigit;
}
