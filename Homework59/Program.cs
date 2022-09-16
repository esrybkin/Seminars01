// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.Clear();
const int ROWS = 4;
const int COLUMNS = 4;
const int MIN = 1;
const int MAX = 10;
Random random = new Random();
int minimum = MAX;

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

int[,] matrix = new int[ROWS, COLUMNS];
matrix = FillArray(ROWS, COLUMNS, MIN, MAX);

PrintArray(matrix);
int ii = 0;
int jj = 0;

for (int i=0; i<ROWS; i++)
{
    for (int j=0; j< COLUMNS; j++)
    {
        if (minimum > matrix[i,j])
        {
            minimum = matrix[i,j];
            ii = i;
            jj = j;
        }
    }
}