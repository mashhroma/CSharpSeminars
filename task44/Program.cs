// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibonacci(int number)
{
    int[] FibArray = new int[number];
    if (number >= 2) FibArray[1] = 1;
    for (int i = 2; i < FibArray.Length; i++)
    {
        FibArray[i] = FibArray[i - 1] + FibArray[i - 2];
    }
    return FibArray;
}

Console.WriteLine("Введите количество чисел Фибоначчи: ");
int num = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Ряд Фибоначчи:");
Console.WriteLine(string.Join(" ", Fibonacci(num)));