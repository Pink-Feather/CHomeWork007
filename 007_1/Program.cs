// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double RandDouble(int minValue, int maxValue) //фу для веещественных чисел
{
    double randomDouble = new Random().NextDouble() * (maxValue - minValue) + minValue; //вещественные числа
    return randomDouble;
}

double[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            result[i, j] = RandDouble(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
     for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            Console.Write($"{inArray[i, j]:f3}\t "); //f3 - округление до 3-х
        }
        Console.WriteLine(); 
    }
}

Console.Clear();
Console.WriteLine("Введите количнство строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количнство столбцов: ");
int col = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(row, col, 0, 90);
PrintArray(array);
