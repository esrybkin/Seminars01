// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("Задайте длину массива: ");
int leng = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int leng)
{
    int[] arr = new int[leng];
    for (int i=0; i<leng;i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());      
    }
    return arr;
}

int[] array = FillArray(leng);
int[] arrayCopy = new int[leng];
for (int i=0; i<leng;i++)
{
    arrayCopy[i] = array[i];
}

Console.WriteLine('[' + string.Join(',', array) + ']');
Console.WriteLine('[' + string.Join(',', arrayCopy) + ']');
