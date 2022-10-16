// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int GetProduct(int numA, int numB)
{
   int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    
    return result;
}

Console.Write("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int product = GetProduct (numA, numB);
Console.WriteLine($"The number A to the power of B is: {product} ");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int DigitSum(int number)
{
    int sum = 0;
    int num = number;
    while(num > 0)
    {
        int current = num % 10;
        num = num / 10;
        sum = sum + current;
    }
    return sum;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = DigitSum(number);
Console.WriteLine($"Sum of digits of {number} is {sum}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size]; 
    for(int i = 0; i < size; i++) 
    {
        Console.Write($"Input a {i+1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "");

    Console.WriteLine(); 
}
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);




