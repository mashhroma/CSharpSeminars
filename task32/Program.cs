// Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] CreateArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray (int[] collection)
{
    Console.Write("[");
    foreach (var item in collection)
    {
        Console.Write(item + " ");
    }
    Console.Write("]");
}

int[] ChangeArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int[] myArray = CreateArray(5, -100, 100);

PrintArray(myArray);
Console.Write(" --> ");
PrintArray(ChangeArray(myArray));