// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до M.

string Numbers(int m, int n)
{
    if (n == m) return $"{n}";
    if (n < m) return $"{n} {Numbers(m, n + 1)}";
    else return $"{Numbers(m, n - 1)} {n}";
}

Console.Write(Numbers(1, 10));