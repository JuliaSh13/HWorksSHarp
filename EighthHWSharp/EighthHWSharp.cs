// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if (array[i, m] < array[i, m + 1])
                {
                    int temp = array[i, m + 1];
                    array[i, m + 1] = array[i, m];
                    array[i, m] = temp;
                }
            }
        }
    }
}

int[,] myArray = CreateRandom2Array();
Show2Array(myArray);
ChangeArray(myArray);
Console.WriteLine();
Show2Array(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinSumStringElements(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        int[] sumStringArray = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
            sumStringArray[i] = sum;
        }

        int minSumString = sumStringArray[0];
        int indexMinSumString = 0;

        for (int i = 0; i < sumStringArray.Length; i++)
            if (minSumString > sumStringArray[i])
            {
                minSumString = sumStringArray[i];
                indexMinSumString = i;
            }
        Console.WriteLine($"The row with the smallest sum of elements: {indexMinSumString + 1}. The sum of the line is equal to: {minSumString}");
    }
    else
    Console.WriteLine("The array is square!");
}

int[,] myArray = CreateRandom2Array();
Show2Array(myArray);
MinSumStringElements(myArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    int matrix1Rows = firstMatrix.GetLength(0);
    int matrix1Cols = firstMatrix.GetLength(1);
    int matrix2Cols = secondMatrix.GetLength(1);
    int[,] product = new int[matrix1Rows, matrix2Cols];
    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    {
        for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++)
        {
            for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++)
            {
                for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++)
                product[matrix1_row, matrix2_col] += firstMatrix[matrix1_row, matrix1_col] * secondMatrix[matrix1_col, matrix2_col];
            }
        }
    }
  return product;
}

int[,] firstArray = CreateRandom2Array();
Console.WriteLine("First matrix: ");
Show2Array(firstArray);

int[,] secondArray = CreateRandom2Array();
Console.WriteLine("Second matrix: ");
Show2Array(secondArray);

int[,] matrixProduct = MatrixProduct(firstArray, secondArray);
Console.WriteLine();
Console.WriteLine("Myltiply matrix: ");
Show2Array(matrixProduct);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] CreateRandom3dArray()
{
    Console.Write("Input number of rows: "); 
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: "); 
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of planes: "); 
    int planes = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] array3d = new int[rows, columns, planes];
  
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int x = 0; x < planes; x++)
            {
                array3d[i, j, x] = new Random().Next(minValue, maxValue+1);
            }
        }
    }    
    return array3d;
}

void Show3dArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int x = 0; x < array3d.GetLength(2); x++)
                Console.Write($" {array3d[i, j, x]} ({i},{j},{x}) ");
        }
    }
    Console.WriteLine();
}

int[,,] array3d = CreateRandom3dArray();
Show3dArray(array3d);
*/