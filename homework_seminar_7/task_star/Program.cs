// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

int DemicalNumbers(string text)
{
    char i = 'I';
    char v = 'V';
    char x = 'X';
    char l = 'L';
    char c = 'C';
    char d = 'D';
    char m = 'M';
    int length = text.Length;
    int result = 0;
    for (int j = 0; j < length; j++)
    {
        if (text[j] == i)
        {
            if (text[j + 1] == v)
            {
                result += 4;
            }
            else if (text[j + 1] == x)
            {
                result += 9;
            }
            else result += 1;
        }
        if (text[j] == v && text[j - 1] != i) result += 5;
        if (text[j] == x && text[j - 1] != i)
        {
            if (text[j + 1] == l)
            {
                result += 40;
            }
            else if (text[j + 1] == c)
            {
                result += 90;
            }
            else result += 10;
        }
        if (text[j] == l && text[j - 1] != x) result += 50;
        if (text[j] == c && text[j - 1] != x)
        {
            if (text[j + 1] == d)
            {
                result += 400;
            }
            else if (text[j + 1] == m)
            {
                result += 900;
            }
            else result += 100;
        }
        if (text[j] == d && text[j - 1] != c) result += 500;
        if (text[j] == m && text[j - 1] != c) result += 1000;
    }
    return result;
}

Console.Write("Введите римское число: ");
string romanNumbers = $" {Console.ReadLine()} ";
int res = DemicalNumbers(romanNumbers);
Console.WriteLine(res);