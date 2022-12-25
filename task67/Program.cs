﻿// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumOfNums (int num)
{
    if (num == 0) return num;
    else return num%10 + SumOfNums(num/10);
}

Console.WriteLine(SumOfNums(4556));