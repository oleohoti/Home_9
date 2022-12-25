// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// int Akkerman(int m, int n)
// {
//     int a =0;
//     if (m==0) a=n+1;
//     else if (m>0 && n==0) a = Akkerman(m-1,n);
//     else if(m>0 && n>0) a=Akkerman(m-1,Akkerman(m,n-1));
//     return a ;
//     // else if (m>0 && n>0) return Akkerman(m-1,Akkerman(m,n-1));
// }
static uint Akkerman(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
try 
{
Console.WriteLine("Введите неотрицательное целое число m");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное целое число n");
uint n = Convert.ToUInt32(Console.ReadLine());
uint ak=Akkerman(m,n);
Console.WriteLine(ak);
}
catch
{
    System.Console.WriteLine($"Негоже так");
}
