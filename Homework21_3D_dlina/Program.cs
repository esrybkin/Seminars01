// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] coordA = new double [3];
double[] coordB = new double [3];

Console.WriteLine("Введите координату X1: ");
coordA[0] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Y1: ");
coordA[1] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Z1: ");
coordA[2] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату X2: ");
coordB[0] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Y2: ");
coordB[1] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Z2: ");
coordB[2] = Convert.ToDouble(Console.ReadLine());

double x = Math.Pow((coordB[0] - coordA[0]),2);
double y = Math.Pow((coordB[1] - coordA[1]),2);
double z = Math.Pow((coordB[2] - coordA[2]),2);

double length = Math.Sqrt(x + y + z);

Console.WriteLine(length);