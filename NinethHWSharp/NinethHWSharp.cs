// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNums(int n)
{
    if(n < 1) return;
    Console.Write(n + " ");
    ShowNums(n - 1);
        
}
ShowNums(8);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumNumbers (int m, int n)
{
    if(m > n) return m += SumNumbers(m - 1, n);
    if(m < n) return m += SumNumbers(m + 1, n);
    else return m;
}

Console.WriteLine(SumNumbers(4, 1));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AkkermanFunction(int n, int m) 
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AkkermanFunction(n - 1, 1);
    else
      return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}

Console.WriteLine(AkkermanFunction(2, 3));
*/