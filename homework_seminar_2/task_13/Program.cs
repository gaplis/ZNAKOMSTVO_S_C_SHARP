// Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num / 100 != 0)
{
    int a3 = (num / 100) % 10;
    if (a3 < 0) a3 = -a3; // Условие создал для того, чтобы, если пользователь вводит
                          // отрицательное число, то выводилось бы положительное третье число (без условия,
                          // например, если бы вводилось число -454, то выводилось бы -4, с данным условием такой проблемы нет:))
    Console.WriteLine($"Третья цифра числа {num} -> {a3}!");
}
else
{
    Console.WriteLine("Третьей цифры нет :С");
}