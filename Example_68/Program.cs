﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Akkerman(int m, int n)
{
    if (m==0) return n+1;
    else if (m>0 && n==0) return 2^m-3;
    // else if (m>0 && n>0) return Akkerman(m-1,Akkerman(m,n-1));
}
try 
{
Console.WriteLine("Введите неотрицательное целое число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное целое число n");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Akkerman(m,n));
}
catch
{
    System.Console.WriteLine($"Негоже так");
}
