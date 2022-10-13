/*
// Задача 1. Напишите программу, которая принимает на вход некоторое число, а выдает сумму этих чисел, от 1 до N.
int GetSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
        sum += current;
    
    return sum;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);

Console.WriteLine($"Sum of elements from 1 to {num} is {s}");
*/

/*
// Задача 2. 
int DigitNumber(int num)
{
    int div = 10;
    int cur = 1;

    for(int n = num; n > 10; cur++)
    {
        n = num / div;
        div *= 10;
    }
    return cur;
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = DigitNumber(num);
Console.WriteLine(res);
*/

/*
// Задача 3. Написать программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
int Factorial(int N)
{
    int fact = 1;

    for(int current = 1; current <= N; current++)
        fact *= current;
    
    return fact;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int fact = Factorial(num);

Console.WriteLine(fact);
*/


// Задача 4. Напишите программу, которая выводит массив системы элементов заполненный 0 и 1 в случайном порядке.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 1;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);