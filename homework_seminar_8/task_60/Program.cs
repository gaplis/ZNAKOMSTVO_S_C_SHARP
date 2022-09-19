// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray(int colString, int colColumnls, int colSizeZ)
{
    int[,,] array = new int[colString, colColumnls, colSizeZ];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void PrintPosition(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} -> ({i}, {j}, {k})");
            }
        }
    }
}

Console.Write("Задайте количество строк массива: ");
int sizeString = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int sizeColumns = int.Parse(Console.ReadLine());
Console.Write("Задайте длину по оси Z массива: ");
int sizeZ = int.Parse(Console.ReadLine());

if (sizeString > 0 && sizeColumns > 0 && sizeZ > 0)
{
        int[,,] myArray = GetArray(sizeString, sizeColumns, sizeZ);
        PrintPosition(myArray);
        Console.WriteLine();
}
else Console.WriteLine("Размер строк и столбцов массива не может быть нулевым или отрицательным.");