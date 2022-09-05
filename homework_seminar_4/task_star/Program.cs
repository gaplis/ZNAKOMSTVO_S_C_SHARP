// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

void Spruce(int number)
{
    int count = 0;
    int amountString = number;
    string star = "*";
    while(count < number)
    {
        int space = 1;
        while(space < amountString)
        {
            Console.Write(" ");
            space++;
        }
        Console.WriteLine(star);
        count++;
        amountString--;
        star = star + "**";
    }
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Spruce(num);

//    *
//   ***
//  *****
// *******
//*********