﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");

int Cycle(int n)
{
    int sum = 0;
    while(n > 0)
    {
        n = n / 10;
        sum += 1;
    }    
    return sum;
}

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Cycle(n));
