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

int[] vocab = new int[MAX];
for (int i=0; i<rows; i++)
        {
            for (int j=0; j< columns; j++)
            {
                if (array[i,j] == 1) vocab[i];
            }
        }