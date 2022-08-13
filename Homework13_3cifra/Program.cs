// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (((a / 100) % 10) == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int b = (a / 100) % 10;
    Console.WriteLine($"{b} третья цифра числа {a}");
}
