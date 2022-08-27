// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Factor(int n)
{
  if (n == 1) return 1;
  else return n * Factor(n-1);
}

Console.WriteLine($"Произведение чисел равно {Factor(n)}");


