// Напишите цикл, который принимает
// на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NaturalDegree(int numA, int numB)
{
    int num = 1;
    for (int i = 0; i < numB; i++)
    {
        num = num * numA;
    }
    return num;
}


Console.WriteLine("ввидите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввидите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());

int naturalDegree = NaturalDegree(number1, number2);
Console.WriteLine($"{number1}, {number2} -> {naturalDegree}");