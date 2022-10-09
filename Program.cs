// Задача 13. Напишите программу, которая выводит третью цифру заданного числа и сообщает что третьей нет
Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine()!);
int z = x;
int y = x / 10;

if (y >= 10 || y <= -10)
{
    while (x > 999 || x < -999)
    {
        x = x / 10;
    }
    if ( x < 0) 
    {
        x = -x;
        Console.WriteLine($" Третья цифра числа {z} -> {(x % 10)}");
    }
    else 
    {
        Console.WriteLine($" Третья цифра числа {z} -> {(x % 10)}");
    }
}
else
{
    Console.WriteLine($"Число н{z} меньше 3 знаков, нет третьяго числа");
}