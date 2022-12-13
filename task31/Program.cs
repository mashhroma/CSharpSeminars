// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] myArray = GetArray(12, -9, 9);
PrintArray(myArray);

int positiveSum=0;
int negativeSum=0;

foreach (var el in myArray)
{
    if (el>0) positiveSum += el;
    else negativeSum += el;
}

Console.WriteLine();
Console.WriteLine ($"Сумма положительных чисел: {positiveSum}");
Console.WriteLine ($"Сумма отрицательных чисел: {negativeSum}");