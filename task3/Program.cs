// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Пожалуйста, напишите целое положительное число");

int Number = int.Parse(Console.ReadLine()!);


if (Number>0)
{
    int index = -Number;
    while (index <= Number)
    {
        Console.Write($"{index} ");
        index++;
    }
}
else
{
    int index = Number;
    while (index <= -Number)
    {
        Console.Write($"{index} ");
        index++;
    }
}
