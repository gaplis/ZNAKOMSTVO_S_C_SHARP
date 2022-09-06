// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] InitArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int SumOdd(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());

if (size > 0)
{
    Console.Write("Задайте минимальное значение чисел: ");
    int numMin = int.Parse(Console.ReadLine());
    Console.Write("Задайте максимальное значение чисел: ");
    int numMax = int.Parse(Console.ReadLine());

    int [] myArray = InitArray(size, numMin, numMax);
    Console.Write("Массив: ");
    Console.WriteLine(String.Join(", ", myArray));

    int result = SumOdd(myArray);
    Console.WriteLine($"Сумма чисел на нечётных позициях: {result}");
}
else
{
    Console.Write("Размер массива не может быть нулевым или отрицательным.");
}