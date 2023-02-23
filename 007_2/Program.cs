// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет

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

void CheckArray(int[,] inArray) //ввод позици элемента//проверка элемента
{
    Console.Write("Введите позицию элемента (строка): ");
    int row = int.Parse(Console.ReadLine()!);
    if (row <= inArray.GetLength(0))
    {
        Console.Write("Введите позицию элемента (столбец):");
        int col = int.Parse(Console.ReadLine()!);
        if (col <= inArray.GetLength(1)) Console.WriteLine(inArray[row, col]);
        else Console.WriteLine("Данный элемент отсутствует");
    }
    else Console.WriteLine("Данный элемент отсутствует");
}

Console.Clear();
Console.WriteLine("Введите количнство строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количнство столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 1000);
PrintArray(array);
CheckArray(array);