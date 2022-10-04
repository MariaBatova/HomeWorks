/*
// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} tne number is greater, respectively {b} the number is less!");
}
else
{
    Console.WriteLine($"{b} tne number is greater, respectively {a} the number is less!");
}
*/

/*
// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Input a first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

int max = firstNum;

if (max < secondNum)
{
    max = secondNum;
}
if (max < thirdNum)
{
    max = thirdNum;
}

 Console.WriteLine($"Max number is {max}");
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}