/*
// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int Number(int num)
{
    int count = 0;

    for(int i = 1; i <= num; i++)
    {
        Console.Write("Input a number: ");
        double m = Convert.ToDouble(Console.ReadLine());
        if(m > 0) count++;
    }
    return count;
}

Console.Write("Input a numbers:");
int num = Convert.ToInt32(Console.ReadLine());
int res = Number(num);
Console.WriteLine($"Positive numbers: {res}");
*/

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
 void Interection(double b1, double b2, double k1, double k2)
 {
    if(k1 == k2) Console.WriteLine("No interection point!");
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = Math.Round(k2 * x + b2, 2);
        Console.WriteLine($"Points of interection of lines: x = {x}, y = {y}");
    }
 }

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Interection(b1, b2, k1, k2);

