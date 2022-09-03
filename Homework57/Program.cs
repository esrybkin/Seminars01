// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


Console.Clear();
const int ROWS = 3;
const int COLUMNS = 3;
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

int vocab1 = 0;
int vocab2 = 0;
int vocab3 = 0;
int vocab4 = 0;
int vocab5 = 0;
int vocab6 = 0;
int vocab7 = 0;
int vocab8 = 0;
int vocab9 = 0;
int vocab0 = 0;

for (int i=0; i<ROWS; i++)
        {
            for (int j=0; j< COLUMNS; j++)
            {
                if (arr[i,j] == 1) vocab1 += 1;
                if (arr[i,j] == 2) vocab2 += 1;
                if (arr[i,j] == 3) vocab3 += 1;
                if (arr[i,j] == 4) vocab4 += 1;
                if (arr[i,j] == 5) vocab5 += 1;
                if (arr[i,j] == 6) vocab6 += 1;
                if (arr[i,j] == 7) vocab7 += 1;
                if (arr[i,j] == 8) vocab8 += 1;
                if (arr[i,j] == 9) vocab9 += 1;
                if (arr[i,j] == 0) vocab0 += 1;
            }
        }


Console.WriteLine($"1 встречается {vocab1} раза");
Console.WriteLine($"2 встречается {vocab2} раза");
Console.WriteLine($"3 встречается {vocab3} раза");
Console.WriteLine($"4 встречается {vocab4} раза");
Console.WriteLine($"5 встречается {vocab5} раза");
Console.WriteLine($"6 встречается {vocab6} раза");
Console.WriteLine($"7 встречается {vocab7} раза");
Console.WriteLine($"8 встречается {vocab8} раза");
Console.WriteLine($"9 встречается {vocab9} раза");
Console.WriteLine($"0 встречается {vocab0} раза");
