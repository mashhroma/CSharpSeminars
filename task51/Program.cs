// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void PrintArray(int[,] array)
{
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
}

int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return array;
}

int DiagonalSum(int[,] array)
{
    int sum = 0;
    int MinLength = array.GetLength(0);
    if (array.GetLength(0) > array.GetLength(1)) MinLength = array.GetLength(0);
    for (int i = 0; i < MinLength; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] myArray = CreateArray(rows, col, 0, 10);
PrintArray(myArray);

Console.WriteLine();

Console.WriteLine($"Сумма чисел по диагонали равна: {DiagonalSum(myArray)}.");