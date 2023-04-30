// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] array2d = CreateMatrix(3, 4, -10, 10);
PrintMatrix(array2d);

Console.Write($"Ведите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write($"Ведите номер столбца: ");
int colum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SearchElement(array2d, row, colum) ? 
                                    $"В ячейке [{row}, {colum}] находится число {array2d[row - 1, colum - 1]}"
                                    : "Такого элемента в массиве нет.");


bool SearchElement (int[,] matrix, int rows, int colums)
{
  return rows <= matrix.GetLength(0) && colums <= matrix.GetLength(1) && rows > 0 && colums > 0;
}

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
