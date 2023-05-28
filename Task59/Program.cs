// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[] СoordinatesMinimumValue(int[,] matrix)
{
    int minIndexRow = 0;
    int minIndexColumn = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minIndexRow, minIndexColumn])
            {
                minIndexRow = i;
                minIndexColumn = j;
            }
        }
    }
    return new int[] { minIndexRow, minIndexColumn };
}

int[,] MatrixWithoutRowColumnMinValue(int[,] matrix, int[] coords)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0, newRow = 0; i < matrix.GetLength(0); i++)
    {
        if (i == coords[0]) continue;
        for (int j = 0, newColumn = 0; j < matrix.GetLength(1); j++)
        {
            if (j == coords[0]) continue;
            newMatrix[newRow, newColumn] = matrix[i, j];
            newColumn ++;
        }
        newRow ++;
    }
    return newMatrix;
}


int[,] array2d = CreateMatrix(4, 5, -10, 10);
PrintMatrix(array2d);
int[] coordinates = СoordinatesMinimumValue(array2d);
int[,] newArray2d = MatrixWithoutRowColumnMinValue(array2d, coordinates);
Console.WriteLine();
PrintMatrix(newArray2d);