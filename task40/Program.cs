// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool CheckTriangle(int a, int b, int c)
{
    bool flag = false;
    if (a < b + c && b < a + c && c < a + b) flag = true;
    return flag;
}

Console.WriteLine("Введите три числа:");
Console.Write("Число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Число B: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Число C: ");
int c = int.Parse(Console.ReadLine()!);

if (CheckTriangle(a, b, c)) Console.WriteLine("С данными сторонами может существовать треугольник.");
else Console.WriteLine("С данными сторонами НЕ может существовать треугольник.");