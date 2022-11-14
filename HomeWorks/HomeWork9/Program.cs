/*
// Задача 64. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void PrintDigits(int n)
{
    Console.Write(n + " ");
    if (n > 1) PrintDigits(n - 1);
}

int n = 8;
Console.Write($"N = {n} -> ");
PrintDigits(n);
*/

/*
// Задача 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumNatureElements(int firstNum, int lastNum)
{
    if (firstNum > lastNum) return firstNum + SumNatureElements(firstNum - 1, lastNum);
    if (firstNum < lastNum) return firstNum + SumNatureElements(firstNum + 1, lastNum);
    else return firstNum;
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = SumNatureElements(m,n);
Console.WriteLine("Сумма натуральных элементов в промежутке от M до N: " + result);
*/

// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m,n - 1));
    return Akkerman(m,n); 
}                  

Console.Write("Введите число m больше 0: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n больше 0: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m,n)}");   