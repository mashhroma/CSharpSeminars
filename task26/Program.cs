// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int NumbCount(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

int count1 = Convert.ToInt32(Math.Ceiling(Math.Log10(num)));
Console.WriteLine(count1);

Console.WriteLine($"Кличество цифр в числе: {NumbCount(num)}");