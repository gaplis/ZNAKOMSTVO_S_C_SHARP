// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int colString, int colColumnls, int minValue, int maxValue)
{
    int[,] array = new int[colString, colColumnls];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
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

int[,] Power2Matrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
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
        int[,] matrix1 = GetArray(sizeString, sizeColumns, numMin, numMax);
        PrintArray(matrix1);
        Console.WriteLine();
        int[,] matrix2 = GetArray(sizeString, sizeColumns, numMin, numMax);
        PrintArray(matrix2);
        Console.WriteLine();
        int[,] newMatrix = Power2Matrix(matrix1, matrix2);
        PrintArray(newMatrix);
    }
    else Console.WriteLine("Максимальное значение числа не может быть меньше минимального.");
}
else Console.WriteLine("Размер строк и столбцов массива не может быть нулевым или отрицательным.");