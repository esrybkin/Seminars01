
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
const int ROWS = 2;
const int COLUMNS = 2;
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

int[,] matrix1 = new int[ROWS, COLUMNS];
int[,] matrix2 = new int[ROWS, COLUMNS];
matrix1 = FillArray(ROWS, COLUMNS, MIN, MAX);
matrix2 = FillArray(ROWS, COLUMNS, MIN, MAX);

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine(); 

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
int[,] finalmatrix = new int[ROWS, COLUMNS];
for (int i=0; i<ROWS; i++)
{
    for (int j=0; j<COLUMNS; j++)
    {
       for (int k=0; k<ROWS; k++)
       {
            finalmatrix[i,j] = finalmatrix[i,j] + matrix1[i,k]*matrix2[k,j];
       }
    }
}
Console.WriteLine("Матрица после перемножения:");
PrintArray(finalmatrix);
}
else
{
Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй матрицы. Перемножать матрицы нельзя!");
}