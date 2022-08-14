// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
number1 = Math.Abs(number1);
int i = 1;

while (i <= number1)
{
    Console.WriteLine(i*i*i);
i++;
}