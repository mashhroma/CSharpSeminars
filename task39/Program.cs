// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void ReverseArray1 (int[] inArray)
{
    for (int i = 0; i < inArray.Length/2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i] = k;
    }
}

int[] ReverseArray2 (int[] inArray)
{
    int[] res = new int [inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        res[i] = inArray[inArray.Length -1 - i];
    }
    return res;
}

int[] myArray = GetArray(10, 0,10);
Console.WriteLine(string.Join(" ", myArray));

int[] newArray = ReverseArray2(myArray);
Console.WriteLine(string.Join(" ", newArray));

ReverseArray1(newArray);
Console.WriteLine(string.Join(" ", newArray));
