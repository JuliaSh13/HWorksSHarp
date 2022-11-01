// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
