﻿// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{ // 0 1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int[] MatrixToArrey(int[,] matrix)
{
    int[] array = new int[matrix.Length];  // создаём одномерный массив с тем же количеством эл-тов, которые есть в двумерном массиве
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintFrequencyDictionarySortedArray(int[] array)
{
    int count = 1;
    int current = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == current) count ++;
        else
        {
            Console.WriteLine($"{current} встречается {count} раз.");
            count = 1;
            current = array [i];
        }
    }
    Console.WriteLine($"{current} встречается {count} раз.");
}


int[,] array2d = CreateMatrix(3, 4, -10, 10);
int[] array1d = MatrixToArrey(array2d);
PrintMatrix(array2d);
Console.WriteLine();
PrintArray(array1d);
Console.WriteLine();
Array.Sort(array1d);
PrintArray(array1d);
Console.WriteLine();
PrintFrequencyDictionarySortedArray(array1d);