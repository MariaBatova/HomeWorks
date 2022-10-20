/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complere!");
    return array;
}
*/
/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}
*/
/*
void ChangeFirstElement(int[] array)
{
    array[0] += 5;
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
ChangeFirstElement(myArray);
ShowArray(myArray);

int a = 5;
int b = a;
*/

/*
void ChangeNumber(int a)
{
    a += 5;
    Console.WriteLine(a);
}

int num = 5;

ChangeNumber(num);
Console.WriteLine(num);
*/

/*
// Задача 1. Напишите программу, которая перевернет одномерный массив.
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ReverseArray(int[] array)
{
    for(int i = 0, last = array.Length -1; i < last; i++, last --)
    {
        int temp = array[i];
        array[i] = array[last];
        array[last] = temp;
    }
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

/*
// Задача 2. Необходимо написать программу, которая принимает на вход три числа и проверяет может ли существовать треугольник со сторонами такой длины.

bool ExistanceTriangle(double a, double b, double c)
{
    // return a < b + c && b < c + c && c < a + b // второй вариант
    if(a < b + c && b < c + c && c < a + b) return true;
    return false;
}

Console.Write("Input size a: ");
double sizeA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input size b: ");
double sizeB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input size c: ");
double sizeC = Convert.ToDouble(Console.ReadLine());
bool res = ExistanceTriangle(sizeA, sizeB, sizeC);
if(res) Console.Write("Triangle exists!");
else Console.Write("Triangle does not exist!");
*/

/*
// Задача 3. Необходимо написать программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        copy[i] = array[i];
    return copy;
}

int[] array = CreateRandomArray();
ShowArray(array);
Console.WriteLine("First array");
int[] array2 = CopyArray(array);
ShowArray(array2);
*/

/*
// Задача 4. Не используя рекурсию необходимо вывести первое N чисел фибоначчи. Первые числа фибоначчи a и b.
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] Fibonacci(int n, int a, int b)
{
    int[] fibArray = new int[n];
    fibArray[0] = a;
    fibArray[1] = b;

    for(int i = 2; i < fibArray.Length; i++)
        fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
    return fibArray;
}

Console.Write("Input size fibonacci: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first number fibonacci: ");
int fib1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number fibonacci: ");
int fib2 = Convert.ToInt32(Console.ReadLine());
int[] array = Fibonacci(size, fib1, fib2);
ShowArray(array);
*/