// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int rows = 3;
int columns = 4;
Random random = new Random();

int[,] FillArray(int rows,int columns)
{
    int[,] array = new int[rows, columns];
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            array[i,j] = random.Next(0,11);
            Console.Write("{0,7:N0}", array[i,j]);
        }
        Console.WriteLine();
    }
    return array;
}

int[,] arr = new int[rows, columns];
arr = FillArray(rows,columns);
double[] sum = new double[columns];
for (int i=0; i<columns; i++)
    {
        for (int j=0; j<rows; j++)
        {
            sum[i] = sum[i] + arr[j,i];  
        }
        sum[i] = sum[i]/rows;     
        Console.Write($"Среднее арифметическое {i+1} столбца: ");
        Console.WriteLine("{0,7:N1}", sum[i]);        
    }
