// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Пожалуйста, напишите цифру дня недели: ");
string DateNum = Console.ReadLine()!;

if (DateNum == "1")
{
    Console.WriteLine("Это - понедельник!");
}

else if (DateNum == "2")
{
    Console.WriteLine("Это - вторник!");
}
else if (DateNum == "3")
{
    Console.WriteLine("Это - среда!");
}
else if (DateNum == "4")
{
    Console.WriteLine("Это - четверг!");
}
else if (DateNum == "5")
{
    Console.WriteLine("Это - пятница!");
}
else if (DateNum == "6")
{
    Console.WriteLine("Это - суббота!");
}
else if (DateNum == "7")
{
    Console.WriteLine("Это - воскресенье!");
}
else
{
    Console.WriteLine("Это - не день недели!");
}