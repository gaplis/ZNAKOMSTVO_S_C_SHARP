// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int RecursionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return RecursionAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return RecursionAkkerman(m - 1, RecursionAkkerman(m, n - 1));
    return RecursionAkkerman(n, m);
}

Console.Write("Введите число M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine());
if (numM >= 0 && numN >= 0)
{
    int res = RecursionAkkerman(numM, numN);
    Console.WriteLine(res);
}
else Console.Write("Числа M и N не могут быть отрицательными.");