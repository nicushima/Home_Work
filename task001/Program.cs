/*9. Напишите программу, которая выводит
1. случайное число из отрезка [10, 99] и показывает
2. наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 
*/

int number = new Random().Next(10, 100); // команда вводит рандомное число 
Console.WriteLine($"случайное число -> {number}"); // выводит в консоль рандомное сисло из (9)

int firstDidit = number / 10; // выводит первое чизло из рандомного 
int secontDigit = number % 10; // выводит второе чизло из рандомного 

if (firstDidit > secontDigit) // ставит условие что если первое число больше второго то выводить в консоль первое 
{
    Console.WriteLine($"наибольшее число -> {firstDidit}");
}
else // ексли не сработает условие то выводит второе сичло 
{
    Console.WriteLine($"наибольшее число -> {secontDigit}");
}
int maxDigit = firstDidit > secontDigit ? firstDidit : secontDigit; // тернанрный оператор  if и else
Console.WriteLine($"наибольшее число -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"наибольшее число -> {maxDigit}");

int MaxDigit(int num) // функция 
{
    int firstDidit = num / 10;
    int secondDigit = num % 10;
    return firstDidit > secondDigit ? firstDidit : secondDigit;
}
