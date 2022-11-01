// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateRandomArray()
{
    Console.Write("Input number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size]; 

    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(min, max + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(); 
}

int CountNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
int countNum = CountNumbers(myArray);
Console.WriteLine($"The count of numbers: {countNum}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("Input a value of b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value of k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value of b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value of k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Coordinates of the intersection point of the lines:({x};{y}).");
*/
