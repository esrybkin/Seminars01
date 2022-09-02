// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
const int ROWS = 2;
const int COLUMNS = 2;
const int ZAXIS = 2;
const int MIN = 10;
const int MAX = 100;
Random random = new Random();

int[,,] FillArray(int rows, int columns, int zaxis, int min, int max)
{
    int[,,] array = new int[rows, columns, zaxis];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < columns; k++)
                {
                    array[i,j,k] = random.Next(min, max);
                }
            }
        }
    return array;
}

void PrintArray(int[,,] arr)
{
        for (int i=0; i<arr.GetLength(0); i++)
        {
            for (int j=0; j< arr.GetLength(1); j++)
            {
                 for (int k=0; k< arr.GetLength(2); k++)
                {
                    Console.Write(arr[i,j,k]);
                    Console.Write("(" + i + "," + j + "," + k + ") ");
                }
            }
        Console.WriteLine();    
        }    
}

int[,,] arr = new int[ROWS, COLUMNS, ZAXIS];
arr = FillArray(ROWS, COLUMNS, ZAXIS, MIN, MAX);
PrintArray(arr);


