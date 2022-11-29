// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Введите первое число: ");
int numberFirst = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numberSecond = int.Parse(Console.ReadLine()!);

if (numberSecond * numberSecond == numberFirst)
{
    Console.Write($"Число {numberFirst} является квадратом числа {numberSecond}.");
}
else
{
    Console.Write($"Число {numberFirst} не является квадратом числа {numberSecond}.");
}