// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.Clear();
const int ROWS = 4;
const int COLUMNS = 4;
int tmp = 1;
int i = 0;
int j = 0;
int[,] matrix = new int[ROWS, COLUMNS];

while (tmp <= matrix.GetLength(0)*matrix.GetLength(1))
{
    matrix[i,j] = tmp;
    tmp +=1;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1) i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1) j--;
    else i--;
}

void PrintArray(int[,] arr)
{
        for (int i=0; i<arr.GetLength(0); i++)
        {
            for (int j=0; j< arr.GetLength(1); j++)
            {
                Console.Write("{0,4:N1}", arr[i,j] + " ");
            }
        Console.WriteLine();    
        }    
}

PrintArray(matrix);

