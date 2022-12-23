// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] MinIndex(int[,] array)
{
    int[] minArray = new int[2];
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minArray[0] = i;
                minArray[1] = j;
            }
        }
    }
    return minArray;
}

int[,] DeleteCrossLine(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int[] minArray = MinIndex(array);
    int minIndexRow = minArray[0];
    int minIndexCol = minArray[1];
    int row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int col = 0;
        if (i != minIndexRow)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != minIndexCol)
                {
                    newArray[row, col] = array[i, j];
                    col++;
                }
            }
            row++;
        }
    }
    return newArray;
}

int[,] myArray = CreateArray(5, 5, 0, 10);
PrintArray(myArray);
Console.WriteLine();

PrintArray(DeleteCrossLine(myArray));