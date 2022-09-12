// Задача со звёздочкой. Напишите программу, которая реализует обход введенного двумерного массива,
// начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

// Гуглил и опирался на данную версию, но пытался адаптировать под нужды данной задачи https://www.haikson.com/programmirovanie/zapolnenie-dvumernoj-matritsyi-po-spirali/

int [,] Array2D(int sizeString, int sizeColumns, int minValue, int maxValue)
{
    int [,]array = new int[sizeString, sizeColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray2D(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

int [] StringArray(int [,] array2D)
{
    int startI = array2D.GetLength(0) - 1;
    int endI = array2D.GetLength(0) - 1;
    int startJ = 0;
    int endJ = 0;
    int [] array = new int[array2D.GetLength(0) * array2D.GetLength(1)];
    int iArray = 0;
    int i = array2D.GetLength(0) - 1;
    int j = 0;
    // Если нижняя сторона и не достагла правой стороны, то двигаемся вправо
    // Если правая сторона и не достагла верхней стороны, то двигаемся вверх
    // Если верхняя сторона и не достигла левой стороны, то двигаемся влево
    // Иначе, двигаемся вниз
    array[iArray] = array2D[i, j];
    iArray++;
    while (iArray < array.Length)
    {
        if (i == startI && j < array2D.GetLength(1) - endJ - 1) j++;
        else if (j == array2D.GetLength(1) - endJ - 1 && i > array2D.GetLength(0) - endI - 1) i--;
        else if (i == array2D.GetLength(0) - endI - 1 && j > startJ) j--;
        else i++;


        if (i == startI - 1 && j == startJ && startJ != array2D.GetLength(1) - endJ - 1)
        {
        startI--;
        endI--;
        startJ++;
        endJ++;
        }
        array[iArray] = array2D[i, j];
        iArray++;
    }
    return array;
}

Console.Write("Введите количество строк массива: ");
int sizeS = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int sizeC = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение чисел: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение чисел: ");
int max = int.Parse(Console.ReadLine());

int [,] myArray2D = Array2D(sizeS, sizeC, min, max);
PrintArray2D(myArray2D);
int [] myArray = StringArray(myArray2D);
Console.WriteLine(String.Join(", ", myArray));