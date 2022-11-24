// Задача 10. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter value: ");
int value = Convert.ToInt32(Console.ReadLine());

int a=value / 100; //первое
int b=value / 10 % 10; //второе
int c=value % 10; // третье

Console.Write(value);
Console.Write("->");
Console.Write(b);