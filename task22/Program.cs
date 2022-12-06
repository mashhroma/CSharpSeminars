// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Задача 22

Console.Write("Введите число N: ");
var N = int.Parse(Console.ReadLine()!);
var i = 1;

while (i <= N)
{
    if (i == N) Console.Write($"{Math.Pow(i, 2)}");
    else Console.Write($"{Math.Pow(i, 2)}, ");
    i++;
}