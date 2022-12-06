// Задача 20
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите значения координат точки А:");
Console.Write("XA: ");
var XA = double.Parse(Console.ReadLine()!);
Console.Write("YA: ");
var YA = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значения координат точки B:");
Console.Write("XB: ");
var XB = double.Parse(Console.ReadLine()!);
Console.Write("YB: ");
var YB = double.Parse(Console.ReadLine()!);

var distance = Math.Round(Math.Sqrt(Math.Pow(XA-XB, 2)+Math.Pow(YA-YB, 2)), 3);

Console.WriteLine($"Расстояние между точками равно: {distance}");