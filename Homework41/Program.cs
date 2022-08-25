// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите количество чисел М: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];
int count = 0;
for (int i=0; i<m; i++)
{
    Console.WriteLine($"Введите {i} число");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел, которые больше 0 равно {count}");
