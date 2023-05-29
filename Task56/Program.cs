// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите необходимое количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите необходимое количество столбцов:");
int column = Convert.ToInt32(Console.ReadLine());

if (Verivication (row, column))
{
    Console.WriteLine("Количество столбцов не должно быть равно количеству строк. Попробуйте ещё раз.");
    return;
}

int[,] array2d = CreateMatrix(row, column, -10, 10);
PrintMatrix(array2d);

int[] arrSumElementRow = SumElementRow(array2d);
Console.WriteLine("Суммы всех строк: ");
PrintArray(arrSumElementRow);
Console.WriteLine();

int minNumber = MinNumberArray(arrSumElementRow);
Console.WriteLine($"Наименьшая сумма из всех строк: {minNumber}");

Console.Write($"Номер(a) строк(и) с наименьшей суммой элементов: ");
PrintNumberRowMinSum (arrSumElementRow, minNumber);



int[] SumElementRow(int[,] matrix)
{
    int []sumElementRow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumElementRow[i]= sum;
    }
return sumElementRow;
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

bool Verivication(int rows, int columns)
{
    return rows == columns || rows < 0 || columns < 0;
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

int MinNumberArray(int[] array)
{
    int minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < minNumber)
            minNumber = array[i];
    return minNumber;
}

void PrintNumberRowMinSum(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == number) Console.Write($"{i + 1} ");
}
