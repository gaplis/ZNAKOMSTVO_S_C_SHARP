// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] InitArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int EvenNumbers(int [] array)
{
    int amountEvenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) amountEvenNum++;
    }
    return amountEvenNum;
}

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());

if (size > 0)
{
    int [] myArray = InitArray(size, 100, 999);
    Console.Write("Массив: " );
    Console.WriteLine(String.Join(", ", myArray));

    int result = EvenNumbers(myArray);
    Console.WriteLine($"Количество чётных чисел в массиве: {result}");
}
else
{
    Console.Write("Размер массива не может быть нулевым или отрицательным.");
}

// int [] myArray = InitArray(size, 100, 999);
// Console.WriteLine(String.Join(", ", myArray));

// int result = EvenNumbers(myArray);
// Console.WriteLine($"Количество чётных чисел в массиве: {result}");