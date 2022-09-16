// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string? number1 = Console.ReadLine()!;
string number2 = string.Empty;

for (int i = 0; i < number1.Length; i++)
{
   number2 = number2 + number1[number1.Length - 1 - i];
}

if (string.Compare(number1, number2) == 0)
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("Число не палиндром");
}