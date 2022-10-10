// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
    // Решение 1.
int FindSecondDigit(int num)
{
    int result;
    int secDig = num / 10 % 10;
    result = secDig;

    return result;
}
    
Console.Write("Input a three-digit: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = FindSecondDigit(number);
Console.Write($"Second digit of {number} is {secondDigit}");


 // Решение 2: Павел, вопрос, почему в этом решении пишет в строке return: Использование локальной переменной "result", которой не присвоено значение, ведь я присвоила  result = num? Что не так в этом решении?

int FindSecondDigit (int num)
{
    int result;
    if(num > 100 && num < 1000)
    {
        num = num / 10 % 10;
        result = num;
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
    return result;
}

Console.Write("Input a three-digit: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = FindSecondDigit(number);
Console.Write($"Second digit of {number} is {secondDigit}");

*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int FindThirdDigitNum(int num)
{
    int result;
        
    if(num <= 99) return -1;
     
    while (num >= 1000)
    {
        num = num / 10;
    }
        num = num % 10;
        result = num;
    
    return result;
}   

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigNum = FindThirdDigitNum(number);

if(thirdDigNum == -1)
{
    Console.WriteLine("There is no third digit!");
}
else
{
    Console.WriteLine($"The third digit of {number} is {thirdDigNum}");
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    
  //Решение 1

/*
void FindWeekdays(int num)
{

    if(num > 1 && num < 6)
        Console.WriteLine("This day is a working day!");
    if(num == 6 | num == 7)
        Console.WriteLine("This day is a day off!");
    
}

Console.Write("Input a number indicating the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

FindWeekdays(number); 
 
 */  
   
    //Решение 2 Павел, можете объяснить, какая тут ошибка синтаксиса? Аналогичная ошибка, как я писала в первой задаче, не присвоено значение return. 
    
  /*  
int FindWeekdays(int num)
{
    int result;

    if(num > 1 && num < 6)
        result = 0;
    if(num == 6 | num == 7)
        result = 1;
    return result; 
}
Console.WriteLine("Input a number indicating the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

int weekDay = FindWeekdays(number);

if(weekDay == 1) 
{
    Console.WriteLine("This day is a day off!");
}
if(weekDay == 0)
{
    Console.WriteLine("This day is a working day!");
}
*/



