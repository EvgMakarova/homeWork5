// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GetRange( int Length)
{
    int [] array = new int [Length];
    Random rd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rd.Next(100, 1000);
    }
    return array;
}
int GetEvenNumberArray (int [] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array [i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

void PrintArray( int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int [] array = GetRange(4);
PrintArray(array);
int count = GetEvenNumberArray (array);
Console.WriteLine($"Количество четных чисел в массиве = {count}. ");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GetRange( int Length)
{
    int [] array = new int [Length];
    Random rd = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = rd.Next(-10, 100);
    }
    return array;
}

void PrintArray( int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int GetSumOfOddIndex (int [] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum = sum + array[i];
            }
        }
        return sum;
    }
int [] array = GetRange(5);
PrintArray(array);
int summa = GetSumOfOddIndex (array);
Console.WriteLine($"Сумма чисел в массиве, стоящих на нечетных позициях = {summa}. ");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] GetRange( int Length)
{
    double [] array = new double [Length];
    Random rd = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = rd.Next(1, 100);
    }
    return array;
}

void PrintArray( double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

double MinElementOfArray (double [] array)
    {
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
double MaxElementOfArray (double [] array)
    {
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

double DifferenceElements (double max, double min)
{
    double dif = max - min;
    return dif;
}

double [] array = GetRange(5);
PrintArray(array);
double maxElement = MaxElementOfArray(array);
double minElement = MinElementOfArray(array);
double result = DifferenceElements (maxElement, minElement);
Console.WriteLine($"разница между максимальным и минимальным элементами = {result} ");
