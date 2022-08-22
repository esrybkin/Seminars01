// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] FillArray(int size)
{
    double[] arr = new double[size];
    for( int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        arr [i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

double[] array = FillArray(5);
double max = array[0];
double min = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (max < array[j])
    {
        max = array[j];
    }
    else if (min > array[j])
    {
        min = array[j];
    }
}

Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {max-min}");