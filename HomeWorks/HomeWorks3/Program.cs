/*
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно паралиндромом.
bool PalindroneNum(int num)
{
    bool result = true;
    
    while(num > 9)
    {
        int lastDigit = num % 10;
        int firstDigit = num;
        int countOfDigit = 0;

        while(firstDigit >= 10)
        {
            countOfDigit++;
            firstDigit /= 10;
        }

        if(lastDigit != firstDigit)
        {
            result = false;
            break;
        } 

        num = num / 10 % (Convert.ToInt32(Math.Pow(10, countOfDigit - 1)));
    }
    
    return result;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool palindrome = PalindroneNum(number);

if(palindrome)
{
    Console.WriteLine($"Number {number} palindrome");
}
else
{
    Console.WriteLine($"Number {number} is not a palindrome");
}
*/

/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Distance (double xa, double xb, double ya, double yb, double za, double zb)
{
    return Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
}

Console.Write("Input xa-coordinate: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ya-coordinate: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input za-coordinate: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xb-coordinate: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yb-coordinate: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zb-coordinate: ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance between A({xa}, {ya}, {za}) and B({xb}, {yb}, {zb}) ~= {Math.Round(Distance(xa, ya, za, xb, yb, zb), 2)}.");
*/

// Задача 23. Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
void Quart(int N)
{
    int count = 1;
    while(count <= N)
    {
        Console.Write($"{Math.Pow(count, 3)}");
        if(count < N) Console.Write(", ");
        count++;
    }
}

Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
Quart(N);