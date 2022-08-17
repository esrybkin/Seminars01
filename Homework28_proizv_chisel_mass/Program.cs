// Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо можете сами задавать массив чисел) и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
// {2, 3, 4} -> 2, 6, 24
// {5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1

Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [length];
int[] arr2 = new int[length];
int count = 0;
for (int i=0; i<length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

while (count <= length)
{
    for (int k=0; k<arr[count]; k++)
    {
        arr2[k] = arr2[k] * 
    }
}


Console.Write("[");
Console.Write(String.Join(", ", arr));
Console.Write("]");
