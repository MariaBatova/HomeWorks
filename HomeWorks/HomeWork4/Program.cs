/*
// Задача 25. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
int Degree(int a, int b)
{
    int res = a;
    for(int i = 1; i < b; i++)
    {
        res *= a;
    }
    return res;
}
Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int deg = Degree(a, b);
Console.WriteLine($"Number {a} to degree {b} = {deg}");
*/

/*
// Задача 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
int Sum(int N)
{
    int sum = 0;

    while(N > 0)
    {
        sum = sum + N % 10;
        N /= 10;
    }
    return sum;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = Sum(num);
Console.WriteLine(sum);
*/

// Задача 29. Напишите программу, которая задает массив из m элементов и выводит их на экран. 
int[] Array(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(1, 100);
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

int[] myArray = Array(size);
ShowArray(myArray);