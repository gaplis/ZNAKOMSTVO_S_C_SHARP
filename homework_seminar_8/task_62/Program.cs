// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] StringArray(int colString, int colColumns)
{
    int[,] array = new int[colString, colColumns];
    int startI = 0;
    int endI = 0;
    int startJ = 0;
    int endJ = 0;
    int i = 0;
    int j = 0;
    int count = 1;
    // Если верхняя сторона и не достагла правой стороны, то двигаемся вправо
    // Если правая сторона и не достагла нижней стороны, то двигаемся вниз
    // Если нижняя сторона и не достигла левой стороны, то двигаемся влево
    // Иначе, двигаемся вверх
    while (count <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = count;
        if (i == startI && j < array.GetLength(1) - endJ - 1) j++;
        else if (j == array.GetLength(1) - endJ - 1 && i < array.GetLength(0) - endI - 1) i++;
        else if (i == array.GetLength(0) - endI - 1 && j > startJ) j--;
        else i--;


        if (i == startI + 1 && j == startJ && startJ != array.GetLength(1) - endJ - 1)
        {
            startI++;
            endI++;
            startJ++;
            endJ++;
        }
        count++;
    }
    return array;
}

Console.Write("Введите количество строк массива: ");
int sizeS = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int sizeC = int.Parse(Console.ReadLine());

int[,] myArray2D = StringArray(sizeS, sizeC);
PrintArray2D(myArray2D);