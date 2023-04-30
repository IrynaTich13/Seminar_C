// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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


double[] AverageColum (int[,] matrix)
{
    double[] averageColum = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        sum += matrix[i, j];
        double averageRowsSum = Math.Round(sum / matrix.GetLength(0), 1);
        averageColum[j] = averageRowsSum;
    }
    return averageColum;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write(array[array.Length - 1]+".");
}

int[,] array2d = CreateMatrixRndInt(2, 8, -10, 10);
PrintMatrix(array2d);
double[] average = AverageColum(array2d);
Console.WriteLine($"Среднее арифметическое кажого столбца: ");
PrintArray(average);
