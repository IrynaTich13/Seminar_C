// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array2d = CreateMatrix(3, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
SortDescendingElementRow(array2d);
PrintMatrix(array2d);


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

void SortDescendingElementRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)                     //построчная сортировка массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if(matrix[i,j] <= matrix[i,k]) continue;
                int temp = 0;
                temp = matrix[i,j];
                matrix[i,j] = matrix[i,k];
                matrix[i,k] = temp;
                
            }
        }
    }
}


