// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
 
Console.Clear();
int n = 8;
int min = 0;
int max = 1;

int[] Array (int n, int min, int max)
{
    int[] arr = new int[n];
    for (int i=0; i<n; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

Console.Write("[");
Console.Write(String.Join(", ", Array(n, min, max)));
Console.Write("]");

