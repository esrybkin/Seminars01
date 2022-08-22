// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] FillArray(int leng, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[leng];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max + 1);     
    }
    return arr;
}

int[] array = FillArray(4, 100, 999);
int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine('['+ string.Join(",", array)+']');
Console.WriteLine($"Количество чётных чисел в массиве равно {count}");
