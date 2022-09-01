// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int count = 1;

while (count <= n)
{
    int result = count * count * count;
    Console.Write($"{result} ");
    count++;
}