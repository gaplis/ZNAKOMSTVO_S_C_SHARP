// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] InitArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

double [] InitDoubleArray(int N)
{
    double[] arr = new double[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble();
    }
    return arr;
}

double [] FullArray(int [] array, double [] arrayDouble)
{
    double[] arrayFull = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayFull[i] = array[i] + arrayDouble[i];
    }
    return arrayFull;
}

double MaximalElement(double [] array)
{
    double maxSize = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxSize) maxSize = array[i];
    }
    return maxSize;
}

double MinimalElement(double [] array)
{
    double minSize = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSize) minSize = array[i];
    }
    return minSize;
}

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());

if (size > 0)
{
    Console.Write("Задайте минимальное значение чисел: ");
    int numMin = int.Parse(Console.ReadLine());
    Console.Write("Задайте максимальное значение чисел: ");
    int numMax = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (numMax >= numMin)
    {
        int [] myArray = InitArray(size, numMin, numMax);
        double [] myDoubleArray = InitDoubleArray(size);
        double [] fullArray = FullArray(myArray, myDoubleArray);

        Console.Write("Массив: ");
        Console.WriteLine(String.Join(", ", fullArray));
        Console.Write("Целое число: ");
        Console.WriteLine(String.Join(", ", myArray));
        Console.Write("Числа после запятой: ");
        Console.WriteLine(String.Join(", ", myDoubleArray));
        Console.WriteLine();

        double result = MaximalElement(fullArray) - MinimalElement(fullArray);
        Console.WriteLine($"Разница максимального и минимального значений: {result:f5}");
    }
    else
    {
        Console.Write("Максимальное значение числа не может быть меньше минимального.");
    }
}
else
{
    Console.Write("Размер массива не может быть нулевым или отрицательным.");
}