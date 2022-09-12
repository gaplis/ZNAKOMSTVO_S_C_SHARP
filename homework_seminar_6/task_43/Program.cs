// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решение с массивом - пример выводится верно, только другой пример я нашёл k1 = 2, b1: -1, k2: -3, b2: 1, вывод должен быть 0,4, -0,2,
// но выводится 0,4, -0,20000000000000018, не совсем понятно почему, потому что там логически никак больше -0,2 посчитать нельзя)

double [] LineIntersection(double k1, double b1, double k2, double b2)
{
    double [] result = new double[2];
    double x = (b1 - b2) / (k1 - k2);
    x = -x;
    double y = k2 * x + b2;
    result[0] = x;
    result[1] = y;
    return result;
}

Console.Write("Введите k1: ");
double numK1 = int.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double numB1 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double numK2 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double numB2 = int.Parse(Console.ReadLine());

if (numK1 != numK2)
{
    Console.WriteLine(String.Join(", ", LineIntersection(numK1, numB1, numK2, numB2)));
}
else
{
    Console.WriteLine("Прямые параллельны.");
}

// Решение без массива

double LineX (double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k1 - k2);
    x = -x;
    return x;
}

double LineY (double k2, double b2, double xLine)
{
    double y = k2 * xLine + b2;
    return y;
}

Console.Write("Введите k1: ");
double numK1Two = int.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double numB1Two = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double numK2Two = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double numB2Two = int.Parse(Console.ReadLine());

if (numK1 != numK2)
{
    double x = LineX(numK1Two, numB1Two, numK2Two, numB2Two);
    double y = LineY(numK2Two, numB2Two, x);
    Console.WriteLine($"x = {x:f2}, y = {y:f2}");
}
else
{
    Console.WriteLine("Прямые параллельны.");
}