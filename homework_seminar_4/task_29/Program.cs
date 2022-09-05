// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.

int[] InitArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

Console.Write("Укажите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Укажите минимальное значение: ");
int startNum = int.Parse(Console.ReadLine());
Console.Write("Укажите максимальное значение: ");
int endNum = int.Parse(Console.ReadLine());

Console.WriteLine(String.Join(", ", InitArray(size, startNum, endNum)));