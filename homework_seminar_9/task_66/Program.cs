// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int RecursionFindSum(int m, int n)
{
    int result = 0;
    if (m <= n)
    {
        result += n + RecursionFindSum(m, n - 1);
    }
    return result;
}

Console.Write("Введите число M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine());
if (numM <= numN)
{
    int res = RecursionFindSum(numM, numN);
    Console.WriteLine(res);
}
else Console.Write("Число M не может быть меньше числа N");