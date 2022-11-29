// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.Write("Введите, пожалуйста, трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int restNumber = number % 10;

if ((number>-1000 && number < -99) || ((number>99 && number < 1000)))
{
    Console.WriteLine($"Последняя цифра числа: {restNumber}.");
}
else
{
    Console.WriteLine($"Введенное число {number} не является трехзначным.");
}