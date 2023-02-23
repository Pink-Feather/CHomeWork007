// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.WriteLine("Введите количнство строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количнство столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] GetArray(int m, int n, int minValue, int maxValue) //вводим массив
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) //функция которая печатает массив
{
     for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine(); //чтоб выводил ввиде таблицы
    }
}

double[] SrArifmetic(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sredAr = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sredAr += inArray[j, i];
        }
        sredAr = sredAr / inArray.GetLength(0);
        result[j] = sredAr;
    }    
    return result;
}

int[,] array = GetArray(rows, cols, 0, 1000);
PrintArray(array);
double[] result = SrArifmetic(array);
Console.WriteLine($"Среднее арифметическое элементов в каждом столбце: {string.Join(", ", result)}");
