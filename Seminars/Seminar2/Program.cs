/*
// Задача 1. Написат программу, которая выводит случайное число из отрезка от 10 до 99 и показывает наибольшую цифру данного числа.
int FindBiggestDigit(int num)
{
    int max;

    int ed = num % 10;
    int dec = num / 10;

    if(ed > dec)
        max = ed;
    else
        max = dec;

    return max;
}

int number = new Random().Next(10, 100);
int biggestDigit = FindBiggestDigit(number);

Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

/*
// Задача 2. Написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int TwoDigitNumber(int num)
{
    int result;

    int ed = num % 10;
    int dec = num / 100;
    
    result = dec * 10 + ed;
    return result;
}

int number = new Random().Next(100, 1000);
int twoDigitNumber = TwoDigitNumber(number);

Console.WriteLine("Number is: " + twoDigitNumber);
*/

/*
// Задача 3. Написать программу, которая принимает на вход число N и проверяет кратно ли оно одновременно a и b.
bool MultipleNumber(int N, int a, int b)
{
    bool result;

    if(N % a == 0 && N % b == 0)
    {
        result = true;
    }    
    else
    {
        result = false;
    }

    return result;
}

Console.Write("Input a number ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the first divisor ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second divisor ");
int b = Convert.ToInt32(Console.ReadLine());

bool result = MultipleNumber(N, a, b);
Console.WriteLine(result);
*/