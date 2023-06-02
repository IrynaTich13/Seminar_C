// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите необходимое количество строк:");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите необходимое количество столбцов:");
// int column = Convert.ToInt32(Console.ReadLine());

int[,] array2dFirst = CreateMatrix(2, 3, 0, 5);
Console.WriteLine("Первая матрица: ");
PrintMatrix(array2dFirst);

int[,] array2dSecond = CreateMatrix(3, 3, 0, 5);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(array2dSecond);

int[,] multiplicatorMatrixFirstSecond = MultiplicatorMatrixFirstSecond(array2dFirst, array2dSecond);
Console.WriteLine();

// // PrintMatrix(multiplicatorMatrixFirstSecond);
// // if (array2dFirst.GetLength(1) == array2dFirst.GetLength(0)) || (array2dFirst.GetLength(0) == array2dFirst.GetLength(1))
// // {
// //     Console.WriteLine("Результирующая матрица будет:");
// //     PrintMatrix(multiplicatorMatrixFirstSecond);
// // }
// // else Console.WriteLine("Не возможно перемножить матрицы");

if (Verification (array2dFirst, array2dSecond))
{
    Console.WriteLine ("Невозможно перемножить матрицы по правилам перемножения");
    return;
}

Console.WriteLine("Результирующая матрица будет:");
PrintMatrix(multiplicatorMatrixFirstSecond);

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

bool Verification (int[,] matrix1, int[,] matrix2)
{
    return (matrix1.GetLength(0) != matrix2.GetLength(1)); //|| matrix1.GetLength(0) != matrix2.GetLength(1));
}

int[,] MultiplicatorMatrixFirstSecond(int[,] matrix1, int[,] matrix2)
{
    int row = (matrix1.GetLength(0) >= matrix2.GetLength(0)) ? matrix1.GetLength(0) : matrix2.GetLength(0);
    int columns = (matrix1.GetLength(1) >= matrix2.GetLength(1)) ? matrix1.GetLength(1) : matrix2.GetLength(1);
    int[,] multiplyMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                multiplyMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return multiplyMatrix;
}

//////////////////////////////////////

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)   //rows
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)  //columns
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j], 3} ");
//     }
//     Console.WriteLine("|");
//     }
// }

// int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] multiplyMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix2.GetLength(1) ; k++)
//             {
//                 multiplyMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
//             }
//         }
//     }
//     return multiplyMatrix;
// }

// int[,] array2d1 = CreateMatrixRndInt(2, 2, 1, 10);
// int[,] array2d2 = CreateMatrixRndInt(3, 2, 1, 10);
// int[,] myltiplyMatrix = MultiplyMatrix(array2d1, array2d2);

// Console.WriteLine("Первая Матрица:");
// PrintMatrix(array2d1);
// Console.WriteLine();

// Console.WriteLine("Вторая Матрица:");
// PrintMatrix(array2d2);
// Console.WriteLine();

// if (array2d1.GetLength(1) == array2d2.GetLength(0))
// {
//     Console.WriteLine("Результирующая матрица будет:");
//     PrintMatrix(myltiplyMatrix);
// }
// else Console.WriteLine("Не возможно перемножить матрици");