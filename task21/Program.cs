// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите значения координат точки А:");
Console.Write("XA: ");
var XA = double.Parse(Console.ReadLine()!);
Console.Write("YA: ");
var YA = double.Parse(Console.ReadLine()!);
Console.Write("ZA: ");
var ZA = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значения координат точки B:");
Console.Write("XB: ");
var XB = double.Parse(Console.ReadLine()!);
Console.Write("YB: ");
var YB = double.Parse(Console.ReadLine()!);
Console.Write("ZB: ");
var ZB = double.Parse(Console.ReadLine()!);

var distance = Math.Round(Math.Sqrt(Math.Pow(XA-XB, 2)+Math.Pow(YA-YB, 2)+Math.Pow(ZA-ZB, 2)), 2);

Console.WriteLine($"Расстояние между точками равно: {distance}");