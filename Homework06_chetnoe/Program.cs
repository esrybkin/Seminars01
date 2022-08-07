// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0)
{
    Console.Write("Число чётное");
}
else
{
   Console.Write("Число нечетноё"); 
}
