// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Строки и массивы использовать нельзя!

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    int num1 = num % 10;
    int num2 = (num / 10) % 10;
    int num4 = (num / 1000) % 10;
    int num5 = num / 10000;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"Число {num} является палиндромом!");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом :С");
    }
}
else Console.WriteLine("Неверное число.");