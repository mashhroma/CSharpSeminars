// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int ProductNumbs(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product *= i;
    }
    return product;
}

int RecProductNumbs(int number)
{
    if (number == 1) return 1;
    else return number * RecProductNumbs(number - 1);
}

Console.WriteLine($"Произведение чисел до введенного числа: {ProductNumbs(num)}");
Console.WriteLine($"Произведение чисел до введенного числа RecProductNumbs: {RecProductNumbs(num)}");