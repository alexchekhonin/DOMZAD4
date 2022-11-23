// Задача 17. По двум заданным числам проверять
//            является ли одно квадратом другого.

Console.WriteLine("Enter value1: ");
int value1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter value2: ");
int value2 =Convert.ToInt32(Console.ReadLine());

if(value1*value1 == value2)
{
    Console.WriteLine("value2 является квадратом value1");
}
else

if(value2*value2 == value1)
{
    Console.WriteLine("value1 является квадратом value2");
}
else Console.WriteLine("Ни одно из чисел не является квадратом другого");