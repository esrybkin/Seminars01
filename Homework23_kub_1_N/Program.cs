// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
number1 = Math.Abs(number1);
int i = 1;

while (i <= number1)
{
    Console.WriteLine(i*i*i);
i++;
}