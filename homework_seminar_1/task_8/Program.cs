// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int one = 1;

while(one <= num)
{
    if (one % 2 == 0)
    {
        Console.Write($"{one} ");
    }
    one++;
}