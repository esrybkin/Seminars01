﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");

int Cycle(int n)
{
    int sum = 0;
    while(n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;
    }    
    return sum;
}

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Cycle(n));