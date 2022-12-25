﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int FindPow(int num, int pow)
{
    if (pow == 1) return num;
    else return num * FindPow(num, pow - 1);
}

Console.WriteLine(FindPow(3, 5));