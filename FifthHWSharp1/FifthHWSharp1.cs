// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 

    for(int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(); 
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count ++;
    }
    return count;
}

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int result = EvenNumbers(myArray);
Console.WriteLine("The number of even numbers in the array is " +result);
*/


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 

    for(int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(); 
}

int SumOfElemnts(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
            sum = sum + array[i];
    }
    return sum;
}
Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int result = SumOfElemnts(myArray);
Console.WriteLine("Sum of elements is " + result);
*/

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 

    for(int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(); 
}

int FindDifference(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    int result = 0;
    result = max - min;
    return result;
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int difference = FindDifference(myArray);
Console.WriteLine("The difference between maximum and minimum values of the array is " + difference);
*/

