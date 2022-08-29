// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
int m = 4;  //строки
int n = 3;  //столбцы

int[,] array = new int[m, n];
Random random = new Random();
for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            array[i, j] = random.Next(0, 10);
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }

Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine()) - 1;

if (row > array.GetLength(0) || column > array.GetLength(1))
{
    Console.WriteLine("Такой позиции в массиве нет");
}
else
{
    Console.WriteLine(array[row, column]);
}
