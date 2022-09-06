// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.

int[] InitArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void Sort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());

if (size > 0)
{
    Console.Write("Задайте минимальное значение чисел: ");
    int numMin = int.Parse(Console.ReadLine());
    Console.Write("Задайте максимальное значение чисел: ");
    int numMax = int.Parse(Console.ReadLine());

    if (numMax >= numMin)
    {
        int [] myArray = InitArray(size, numMin, numMax);
        Console.Write("Массив: ");
        Console.WriteLine(String.Join(", ", myArray));

        Sort(myArray);
        Console.Write("Невозрастающая сортировка массива: ");
        Console.WriteLine(String.Join(", ", myArray));
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