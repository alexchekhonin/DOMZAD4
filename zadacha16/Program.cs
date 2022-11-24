// Задача 16. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.Write(dayNumber);
        Console.WriteLine(" -> да");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("это вообще не день недели");
    }
    else
    {
        Console.Write(dayNumber);
        Console.Write(" -> нет");
    }
}

