// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Sum(int M, int N)
{
    if (M<=N) return M+Sum(M+1,N);
    else  return 0; 
}
try{
Console.WriteLine("Введите значение M :");
int M = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Введите значение N :");
int N = Convert.ToInt32(System.Console.ReadLine());
if (Sum(M,N)==0)Console.WriteLine("Число M больше числа N");
else System.Console.WriteLine($"сумму натуральных элементов в промежутке от M до N равна {Sum(M,N)}");
}
catch
{
    System.Console.WriteLine($"Негоже так");
}
