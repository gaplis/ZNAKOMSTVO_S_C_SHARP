// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiate(int xA, int xB)
{
    int result = xA;
    for (int i = 1; i < xB ; i++)
    {
        result = result * xA; 
    }
    return result;
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine(Exponentiate(A, B));