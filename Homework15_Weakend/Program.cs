// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1 || a > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else if (a >= 1 & a < 6)
{
    Console.WriteLine("Это будний день");
}

else if (a >= 6 & a < 8)
{
    Console.WriteLine("Это выходной день");
}
