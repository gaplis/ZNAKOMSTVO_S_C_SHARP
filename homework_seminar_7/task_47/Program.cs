// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[,] InitArray(int colString, int colColumns, int min, int max)
{
    int[,] array = new int[colString, colColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

double[,] InitDoubleArray(int colString, int colColumns)
{
    double[,] array = new double[colString, colColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
    return array;
}

double[,] FullArray(int[,] array, double[,] arrayDouble)
{
    double[,] arrayFull = new double[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < arrayFull.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFull.GetLength(1); j++)
        {
            arrayFull[i, j] = array[i, j] + arrayDouble[i, j];
        }
    }
    return arrayFull;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void PrintDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2}\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте количество строк массива: ");
int sizeString = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int sizeColumns = int.Parse(Console.ReadLine());

if (sizeString > 0 && sizeColumns > 0)
{
    Console.Write("Задайте минимальное значение чисел: ");
    int numMin = int.Parse(Console.ReadLine());
    Console.Write("Задайте максимальное значение чисел: ");
    int numMax = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (numMax >= numMin)
    {
        int[,] myArray = InitArray(sizeString, sizeColumns, numMin, numMax);
        double[,] myDoubleArray = InitDoubleArray(sizeString, sizeColumns);
        double[,] myFullArray = FullArray(myArray, myDoubleArray);

        PrintArray(myArray);
        Console.WriteLine();

        PrintDoubleArray(myDoubleArray);
        Console.WriteLine();

        PrintDoubleArray(myFullArray);
        Console.WriteLine();
    }
    else Console.WriteLine("Максимальное значение числа не может быть меньше минимального.");
}
else Console.WriteLine("Размер строк и столбцов массива не может быть нулевым или отрицательным.");