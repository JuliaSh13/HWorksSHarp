// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"Number {a} more than number {b}");
}
else
{
    Console.WriteLine($"Number {a} less than number {b}");
}
*/

//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int numMax = n1;

if(n2 > n1)
{
    numMax = n2;
}

if(n3 > n2)
{
    numMax = n3;
}
Console.WriteLine($"Biggest number is {numMax}");
*/

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine($"Number {num} is even");
}
else
{
    Console.WriteLine($"Number {num} is odd");
}
*/

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= n)
{
    if (current % 2 == 0)
    Console.Write(current + " ");

    current++;
}
*/