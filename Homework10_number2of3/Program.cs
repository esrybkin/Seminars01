﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  456 -> 5
//  782 -> 8
//  918 -> 1


Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
a = Math.Abs(a);
if (a / 1000 == 0 && a /100 != 0)
{
    int b = (a / 10) % 10;
    Console.WriteLine($"{b} вторая цифра числа {a}");
}
else
{
    Console.WriteLine("Это неверное число");
}
