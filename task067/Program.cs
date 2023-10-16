// int Factorial(int n) // 5 4 3 2 1
// {
// 	if(n == 1) return 1;
// 	return n * Factorial(n - 1); // 5 4 3 2 
//     // return (1) * 2 * 3 * 4 * 5 = 120

// }

// Console.WriteLine(Factorial(5)); // 120

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Factorial(int n) // 5 4 3 2 1
{
	if(n == 1) return 1;
	return n * Factorial(n - 1); // 5 4 3 2 
    // return (1) * 2 * 3 * 4 * 5 = 120

}

Console.WriteLine(Factorial(5)); // 120