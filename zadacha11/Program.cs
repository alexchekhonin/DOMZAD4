// Задача 11. 
// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// Выводим слуайное число из отрезка 10-99
// Определяем 1 и 2 цифру числа
// Сравниваем 1 и 2 цифру числа
// Выводим наибольшую

Console.Clear();
int value = new Random().Next(10, 100);
int a=value / 10;
int b = value % 10;

if (a>b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}
Console.WriteLine(value);
