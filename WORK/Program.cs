// вид 1 - не принемает и не отдает данные 
void Method1()
{
    Console.WriteLine("автор");
}
//Method1();



// вид 2 - ТОЛЬКО ПРИНЕМАЕТ ДАННЫЕ 
void Method2(string msg, int count) // string - текст; int - целоле число.
{
    int i = 0;
    while (i < count) // повторяется пока i не будет больше или равна count 
    {
        Console.WriteLine(msg); // во время каждого повторения while выводит msg
        i ++;
    }  
}
// Method2("текст", 4); // "текст" - msg; 4 - count.
// если хотим указатьь значение преременной то пишм Method2(msg:"текст", count: 4); для того чтобы можно было писать не по порядку 


// вид 3 - ТОЛЬКО ОТДАЕТ ДАННЫЕ 

int Method3()
{
    return DateTime.Now.Year; // вывод команды котороя паказывает год
}

int year = Method3(); //присваевание переменной функции
// Console.WriteLine(year); // вывод переменной с функцией 


// вид 4 - и принемае  и отдает данные 

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "текст"); 
//Console.WriteLine(res); 



for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine($" {i} x {j} = {i*j}");
    }
    Console.WriteLine();
}