// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double [,] Create2DRandomArrayRealNumbers() 
{
    Console.Write("Input the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    double min = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    double max = Convert.ToDouble(Console.ReadLine());
    
    double[,] array = new double[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++) 
        {
            array[i, j] = new Random().NextDouble()* ((max) - (min)) + (min); 
            array[i, j] = Math.Round(array[i, j], 2);
        }
    return array;
}    
void Print2DArrayRealNumbers(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    { 
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
            Console.WriteLine();
    }  
}
double[,] ArrayRealNumbers = Create2DRandomArrayRealNumbers();
Print2DArrayRealNumbers(ArrayRealNumbers);
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2Array()
{
    Console.Write("Input number of rows: "); 
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: "); 
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, colums]; 

    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2Array(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
            Console.WriteLine();
    }
}

Console.Write("Input the number of row to find: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of column to find: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] numbers = CreateRandom2Array();
Show2Array(numbers);
    if (a > numbers.GetLength(0) && b > numbers.GetLength(1))
    {
        Console.WriteLine("There is no such element!");
    }
    else
    {
        Console.WriteLine($"Еhe value of the element {a} row and {b} colums is {numbers[a-1,b-1]}");
    }
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Input number of rows: "); 
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: "); 
int colums = Convert.ToInt32(Console.ReadLine());
    
int[,] array = new int[rows, colums];
FillArrayRandomNumbers(array);

for(int i = 0; i < array.GetLength(0); i++) 
{
    double arithmeticMean = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arithmeticMean = (arithmeticMean + array[i, j]);
        }
        arithmeticMean = arithmeticMean / rows;
        Console.Write(arithmeticMean + "; ");
}
Console.WriteLine();
Show2Array(array);

void FillArrayRandomNumbers(int[,] array)
{
    for(int j = 0; j < rows; j++) 
    {
        for(int i = 0; i < colums; i++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void Show2Array(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++) 
    {
        for(int i = 0; i < array.GetLength(0); i++)
            Console.Write(array[i,j] + " ");
            Console.WriteLine();
    }
}




