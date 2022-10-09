/*
// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выход показывает вторую цифру этого числа.

Console.Write("Input three-degit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 100 / 10;

Console.WriteLine(result);
*/

/*
// Задача 13. Напишите программу, которая выводит третью цифру заданного числа и сообщает, что третьей цифры нет.
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100 & num <= 999)
{
    int res = num % 10;
    Console.WriteLine($"Fhird digit: {res}");
}
else if(num >= 1000 & num <= 9999)
{
    int res = num / 10 % 10;
    Console.WriteLine($"Fhird digit: {res}");
}
else if(num >= 10000 & num <= 99999)
{
    int res = num / 100 % 10;
    Console.WriteLine($"Fhird digit: {res}");
}
else
    Console.WriteLine("No third digit!");
*/

// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool TheWeekDay(int d);
{
    bool result;

    if(d == 6 && d == 7)
    {
        result = true;
    }    
    else
    {
        result = false;
    }

    return result;
}

Console.Write("Enter the number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

bool TheWeekDay = TheWeekDay(num);
if (TheWeekDay)
{
    Console.WriteLine($"{num} day of the week is a Holiday"); 
}
else
{
    Console.WriteLine($"{num} day of the week is not a Holiday"); 
}
