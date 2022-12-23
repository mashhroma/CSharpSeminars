// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ChangeRowsCols(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(0)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(0); j++)
        {
            newArray[i, j] = array[j, i];
        }
    }
    return newArray;
}

int[,] myArray = CreateArray(5, 7, 0, 10);
PrintArray(myArray);
Console.WriteLine();

if (myArray.GetLength(0) != myArray.GetLength(1))
    Console.WriteLine("Изменить данный массив невозможно.");
else
    PrintArray(ChangeRowsCols(myArray));