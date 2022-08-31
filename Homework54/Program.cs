// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
const int ROWS = 3;
const int COLUMNS = 4;
const int MIN = 1;
const int MAX = 10;
Random random = new Random();

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
        for (int i=0; i<rows; i++)
        {
            for (int j=0; j< columns; j++)
            {
                array[i,j] = random.Next(min, max);
            }
        }
    return array;
}

void PrintArray(int[,] arr)
{
        for (int i=0; i<arr.GetLength(0); i++)
        {
            for (int j=0; j< arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j] + " ");
            }
        Console.WriteLine();    
        }    
}

int[,] arr = new int[ROWS, COLUMNS];
arr = FillArray(ROWS, COLUMNS, MIN, MAX);
Console.WriteLine("Оригинальный массив");
PrintArray(arr);

void SortArray(int[,] arr)
{
    int temp = arr[0,0];
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int k=0; k<arr.GetLength(1); k++)
        {
            for (int j=1; j<arr.GetLength(1); j++)
            {
                if (arr[i,j] > arr[i,j-1])
                {
                    temp = arr[i,j];
                    arr[i,j] = arr[i,j-1];
                    arr[i,j-1] = temp;
                }
            }
        }    
    }
}

Console.WriteLine();
Console.WriteLine("Отсортированный массив");
SortArray(arr);
PrintArray(arr);
