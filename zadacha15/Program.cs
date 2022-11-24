// Задаа 15. Дано число. Проверить кратно ли оно 7 и 23
// Вводим число
// Делим на 7 и 23
// Если делится - то кратно
// Если нет - не кратно

Console.WriteLine("Enter value: ");
int value = Convert.ToInt32(Console.ReadLine());

int a = value % 7;
int b = value % 23;

if (a == 0 & b == 0)
{
    Console.WriteLine("Кратно");
}

else
{
    Console.WriteLine("Не кратно");
}
