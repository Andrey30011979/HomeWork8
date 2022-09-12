// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] mass = new int[4, 6];

FillArray(mass);
Print(mass);
Console.WriteLine();

int[] rowSum = new int[mass.GetLength(0)];

// Расчёт построчных сумм

for (int i = 0; i < mass.GetLength(0); i++)
{
    rowSum[i] = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        rowSum[i] += mass[i, j];
    }
    Console.Write(rowSum[i] + " "); 
}

int min = rowSum[0];
int minL = 0;

for (int l = 0; l < rowSum.Length; l++)
{
    if (rowSum[l] < min)
    {
        min = rowSum[l];
        minL = l;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов – {minL}");
