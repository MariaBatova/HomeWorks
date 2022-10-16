/*
// Задача 1. Задать массив из 12 элементов заполенный случайными числами из промежутка от -9 до 9 и найти сумму отрицательных и положительных элементов массива.
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("/nComplere!");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int result = SumOfNegatives(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of a negative elements is " + result);
*/

/*
// Задача 2. Написать программу замены (опечатка) элементов массива положительные элементы заменяем на соответсвующие отрицательные и наоборот.
int[] CreateRandomArray(int size, int minValue, int maxValue)
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

int[] ReversedArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * -1;
    return array;
}

int[] myArray = CreateRandomArray(5, -100, 100);
ShowArray(myArray);
int[] reversed = ReversedArray(myArray);
ShowArray(reversed);
*/

/*
// Задача 3. Необходимо задать массив и написать программу которая определяет присутствует ли заданное число в массиве.
int[] CreateRandomArray(int size, int minValue, int maxValue)
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

bool Find(int num, int[] array)
{
    bool find = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            find = true;
            break;
        } 
    } 
    return find;
}
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number to find: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, -10, 10);
bool find = Find(number, newArray);

ShowArray(newArray);
Console.WriteLine($"Number {number} in array, is {find}");
*/

// Задача 4. Необходимо задать одномерный массив из 12 случайных чисел и найти количество элементов значение которых лежат на отрезке от 10 до 99.
int[] CreateRandomArray(int size, int minValue, int maxValue)
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

int minValue = 10;
int maxValue = 99;
int Count(int[] array, int minValue, int maxValue)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= minValue && array[i] <= maxValue) count++;
    return count;
}

int[] arrayToFind = CreateRandomArray(12, -100, 150);
ShowArray(arrayToFind);
int count = Count(arrayToFind, minValue, maxValue);
Console.WriteLine($"Внутри вашего массива содержится {count} элементов в диапазоне от {minValue} до {maxValue}");
