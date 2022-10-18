/*
// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];

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

int CountNum(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count++;
    }
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(size, 100, 999);
ShowArray(newArray);
Console.WriteLine($"In an array {CountNum(newArray)} of even numbers");
*/

/*
// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];

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

int Sum(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(size, 1, 50);
ShowArray(newArray);
Console.WriteLine($"Sum of elements in odd position = {Sum(newArray)}");
*/

// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] Array(int size)
{
    double[] array = new double[size];
    {
        for(int i = 0; i < size; i++)
        {
            Console.Write("Input array number: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        return array;
    }
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];

    for(int i =1; i < array.Length; i++)
        if(array[i] > max) max = array[i];
        else
            if(array[i] < min) min = array[i];
    return max - min;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] newArray = Array(size);
ShowArray(newArray);
double result = Difference(newArray);
Console.WriteLine($"Difference between maximum and minimum elements = {Difference(newArray)}");