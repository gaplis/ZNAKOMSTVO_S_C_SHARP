// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int [] UserArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void AboveZeroNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Количество чисел больше нуля: {count}");
}

Console.Write("Введите количество чисел: ");
int amount = int.Parse(Console.ReadLine());

if (amount > 0)
{
    int [] numbers = UserArray(amount);
    Console.WriteLine(String.Join(", ", numbers));
    AboveZeroNumbers(numbers);
}
else if (amount == 0) Console.WriteLine("Чисел нет.");
else Console.WriteLine("Количество чисел не может быть меньше нуля.");

// Тут была моя попытка реализовать функцию, которая и без дополнительных вопросов о количестве чисел сама бы их считала, 
// но что-то у меня не особо получилось, полагаю дело в том, что я изначально задаю размер массива и дальше он не увеличивается,
// а в варианте со строками не могу понять, почему не конвертируется в ToInt32) 
// Но надеюсь, что я хотя бы шёл в правильном направлении)

/* int [] UserArray2()
{
    int size = 1;
    int [] array = new int [size];
    string yesOrNo = String.Empty;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        array[i] = int.Parse(Console.ReadLine());
        Console.Write("Продолжить?: ");
        yesOrNo = Console.ReadLine();
        if (yesOrNo.ToLower() == "да") array[size++];
        else break;
    }
    return array;
}

AboveZeroNumbers(UserArray2()); 

string UserArray3()
{
    int size = 1;
    string numbers = String.Empty;
    string yesOrNo = String.Empty;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        numbers += Console.ReadLine();
        Console.Write("Продолжить?: ");
        yesOrNo = Console.ReadLine();
        if ( yesOrNo.ToLower() == "да") 
        {
            numbers += ", ";
            size++;
        }
        else 
        {
            Console.WriteLine(numbers);
            break;
        }
    }
    Console.WriteLine();
    return numbers;
}

int [] array = {Convert.ToInt32(UserArray3())};
AboveZeroNumbers(array); */