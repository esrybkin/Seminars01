// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
int sum = 0;

void Metod(int number1, int number2)
{
    if (number1 > number2) return;
    Metod(number1 + 1, number2);
    sum = sum + number1;
}

Metod(n, m);
Console.Write(sum);