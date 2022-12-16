// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray (int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

int[] CreateArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

int[] myArray1 = CreateArray(10,0,100);
Console.Write("Дан массив: ");
Console.WriteLine(string.Join(" ", myArray1));

int[] myArray2 = CopyArray(myArray1);
Console.Write("Копия массива: ");
Console.WriteLine(string.Join(" ", myArray2));