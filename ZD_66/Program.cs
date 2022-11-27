// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите начало интервала N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало интервала M ");
int m = Convert.ToInt32(Console.ReadLine());

int SumDigits(int n, int m)
{
    int sum = 0;
    while (n <= m)
    {
        sum = sum + n;
        n++;
    }
    return sum;
}
Console.WriteLine(SumDigits(n,m));

