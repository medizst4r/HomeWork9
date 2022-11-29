/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void RecursShowNum (int n)
{
    Console.Write(n + " ");
    if (n > 1) RecursShowNum (n-1);
    if (n < 1) RecursShowNum (n+1);
}
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
RecursShowNum(n);
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int RecursSumFromTo(int m, int n)
{
    if (m > n) return RecursSumFromTo(m - 1, n) + m;
    if (m < n) return RecursSumFromTo(m + 1, n) + m;
    else return n;
}
Console.WriteLine("Input a number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number n: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = RecursSumFromTo(m, n);
if (n >= m) Console.Write($"Sum of numbers from {m} to {n} is {sum}");
else Console.Write($"Sum of numbers from {n} to {m} is {sum}");
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AkkermanFunc(m - 1, 1);
    else return AkkermanFunc((m - 1), AkkermanFunc(m, n - 1));
}

Console.WriteLine("Input a number m above than zero: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number n above than zero: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

bool TestNum(int m, int n)
{
    if (n >= 0 && m >= 0) return true;
    else return false;
}


while (TestNum(m, n) == false)
{
    Console.WriteLine("Entered the wrong number!");
    Console.WriteLine();
    Console.WriteLine("Input a number M above than zero.");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number N above than zero.");
    n = Convert.ToInt32(Console.ReadLine());
}
if (TestNum(m, n) == true)
{
    int sum = AkkermanFunc(m, n);
    if (n >= m) Console.Write($"{sum}");
    else Console.Write($"{sum}");
}
*/