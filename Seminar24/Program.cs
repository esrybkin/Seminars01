// Задача 24. Напишите программу, которая на вход принимает число (А) и выдаёт сумму всех чисел от 1 до A.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Cycle(int a)
{
    int sum = 0;
    for (int i=1; i<=a; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Cycle(a));
