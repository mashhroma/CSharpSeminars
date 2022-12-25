//Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void Numbers(int numb)
{
    if (numb != 1) Numbers(numb - 1);
    Console.Write(numb + " ");
}

Numbers(4);