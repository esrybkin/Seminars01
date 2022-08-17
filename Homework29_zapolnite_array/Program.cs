// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int length = 8;
int[] arr = new int [length];
for (int i=0; i<length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("[");
Console.Write(String.Join(", ", arr));
Console.Write("]");
