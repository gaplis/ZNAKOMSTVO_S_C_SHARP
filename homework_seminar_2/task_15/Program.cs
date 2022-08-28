// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число недели: ");
int weekDay = int.Parse(Console.ReadLine());

if (weekDay > 0 && weekDay < 8)
{
    if (weekDay == 6 || weekDay == 7)
    {
        Console.WriteLine("Это - выходной.");
    }
    else
    {
        Console.WriteLine("Это - будний день.");
    }
}
else
{
    Console.WriteLine("Неверный день недели :С");
}