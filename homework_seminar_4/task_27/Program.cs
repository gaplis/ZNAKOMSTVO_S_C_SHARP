// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int number)
{
    int result = 0;
    while(number != 0)
    {
        int percent = number % 10;
        result += percent;
        number = number / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(Sum(num));