// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] FillArray(int size, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i=0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

int sum = 0;
int[] array = FillArray(10, -30, 30);
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 != 0)
    {
        sum = sum + array[j];
    }
}

Console.WriteLine('[' + string.Join(',', array)+']');
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
