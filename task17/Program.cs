// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите число для координаты Х: ");
int X = int.Parse(Console.ReadLine()!);
Console.Write("Введите число для координаты Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (X>0 && Y>0) Console.WriteLine("I четверть");
if (X<0 && Y>0) Console.WriteLine("II четверть");
if (X<0 && Y<0) Console.WriteLine("III четверть");
if (X>0 && Y<0) Console.WriteLine("IV четверть");