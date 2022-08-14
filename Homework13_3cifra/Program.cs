// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  645 -> 5
//  78 -> третьей цифры нет
//  32679 -> 6

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
a = Math.Abs(a);
if (a / 100  == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (a / 1000 != 0)
    {
    a = a / 10;
    }
    a = a % 10;
    Console.WriteLine(a);
}