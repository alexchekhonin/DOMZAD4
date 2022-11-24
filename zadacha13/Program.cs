// Задача 13. Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter value: ");
int value = Convert.ToInt32(Console.ReadLine());

int a=value / 100; //первое
int b=value / 10 % 10; //второе
int c=value % 10; // третье

Console.WriteLine(value);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
