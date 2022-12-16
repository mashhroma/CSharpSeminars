// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string BinaryNumber(int num)
{
    string result = String.Empty;
    while (num > 0)
    {
        result = Convert.ToString(num % 2) + result;
        num /= 2;
    }
    return result;
}

Console.WriteLine("Введите число для его преобразования в двоичную систему:");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {number} в двоичной системе: {BinaryNumber(number)}");