// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    foreach (var item in collection)
    {
        Console.Write(item + " ");
    }
    Console.Write("]");
}

void FindInArray(int[] collection, int find)
{
    bool flag = false;
    foreach (var item in collection)
    {
        if (item == find)
        {
            Console.WriteLine("ЕСТЬ");
            flag = true;
            break;
        }
    }
    if (flag == false) Console.WriteLine("НЕТ");
}

int[] myArray = CreateArray(5, 0, 10);
int num = 6;

PrintArray(myArray);
Console.Write($"  - Есть ли в данном массиве число {num}? -  ");
FindInArray(myArray, num);
