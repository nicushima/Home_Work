// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int SumPozitivNumber(int num1, int num2, int num3, int num4, int num5)
{
    int sum = 0;
    if (num1 > 0)
    {
        sum += 1;
    }    
    if (num2 > 0)
    {
        sum += 1;
    }  
    if (num3 > 0)
    {
        sum += 1;
    }   
    if (num4 > 0)
    {
        sum += 1;
    }   
    if (num5 > 0)
    {
        sum += 1;
    }   
    return sum;
}

Console.WriteLine("ввидите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввидите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввидите третье целое число");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввидите четвертое целое число");
int number4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввидите пятое целое число");
int number5 = Convert.ToInt32(Console.ReadLine());


int sumPozitivNumber = SumPozitivNumber(number1,number2,number3,number4,number5);
Console.WriteLine($"{number1}, {number2}, {number3}, {number4}, {number5}, -> {sumPozitivNumber}");