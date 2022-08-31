// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
const int ROWS = 4;
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
PrintArray(arr);

int[] sum = new int[ROWS];
int minstring = MAX*10;
for (int i=0; i<arr.GetLength(0); i++)
{
    for (int j=0; j< arr.GetLength(1); j++)
    {
        sum[i]=sum[i] + arr[i,j];
    }
    if (minstring > sum[i])
        {
            minstring = sum[i]; 
        }
}


Console.WriteLine();
Console.Write("Сумма элементов каждой строки:");
Console.WriteLine('[' + string.Join(',',sum) + ']');
Console.WriteLine();
Console.WriteLine("Номера строк с наименьшей суммой элементов:");



int[] count = new int[ROWS];
int p = 0;
for (int i=0; i< ROWS; i++)
{
    if (minstring == sum[i])
    {
        count[p] = i+1;
        Console.WriteLine(count[p]);
        p+=1;
    }
}
