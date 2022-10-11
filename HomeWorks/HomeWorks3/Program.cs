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

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Задача 23. Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
