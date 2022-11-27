// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


 Console.Write ("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine());

string Rec(int n)
{
    if (n==0) return " ";
    return  Rec(n-1) +" " + n;
    
}

Console.WriteLine($" {Rec(n)} ");


