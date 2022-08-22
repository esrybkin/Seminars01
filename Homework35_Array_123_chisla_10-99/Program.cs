// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] FillArray(int size, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i=0; i<size;i++)
    {
        arr [i] = rand.Next(min, max+1);
    }
    return arr;
}

int[] array = FillArray(123, 0, 999);
int count = 0;
for (int j=0;j<array.Length; j++)
{
    if (array[j]>=10 & array[j]<=99)
    {
        count++;
    }
}
Console.WriteLine('['+ string.Join(',', array)+']');
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно {count}");