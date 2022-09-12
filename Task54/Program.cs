// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
 
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

int[,] mass = new int[3, 4];

FillArray(mass);
Print(mass);
Console.WriteLine();

int min = 0;
int save = 0;
int MinJ = 0;

for (int l = 0; l < mass.GetLength(1); l++)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        min = mass[i, 0];
        for (int j = 0; j < mass.GetLength(1) - l; j++)
        {
            if (mass[i, j] <= min)
            {
                min = mass[i, j];
                MinJ = j;
            }
        }
        save = mass[i, mass.GetLength(1) - 1 - l];
        mass[i, mass.GetLength(1) - 1 - l] = mass[i, MinJ];
        mass[i, MinJ] = save;
    }
} 

Print(mass);

