// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

int[,] ChangeArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = array[0,i];
        array[0,i] = array[array.GetLength(1)-1,i];
        array[array.GetLength(1)-1,i] = temp;
    }
    return array;
}

int[,] myArray = CreateArray(5, 5, 0, 10);
PrintArray(myArray);
Console.WriteLine();
PrintArray(ChangeArray(myArray));