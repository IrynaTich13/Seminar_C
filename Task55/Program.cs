// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);

Console.WriteLine();
if (SquareMatrix(array2d))
{
    ChangeMatrix(array2d);
    PrintMatrix(array2d);
}
else Console.WriteLine("Ошибка. Число строк не равно числу столбцов.");

bool SquareMatrix(int[,] matrix)
{
    return (matrix.GetLength(0) == matrix.GetLength(1));
}

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
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

//////////////////

// int[,] CreateMatrix(int rows, int min, int max)
// {
//     int[,] matrix = new int[rows, rows];

//     Random random = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.Next(min, max + 1);
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],4} ");
//         }

//         Console.Write("|");
//         Console.WriteLine();

//     }
// }

// bool Verification(int rows, int colums)
// {
//     return rows != colums || rows < 0 || colums < 0;
// }

// int[,] ChangeColumsRows(int[,] matrix)
// {
//     int size = matrix.GetLength(0);
//     int[,] newMatrix = new int[size, size];
//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size; j++)
//         {
//             newMatrix[j, i] = matrix[i, j];
//         }
//     }
// }
