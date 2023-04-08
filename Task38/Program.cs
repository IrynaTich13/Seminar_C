// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArreyRndDouble(5, -100, 100);
PrintArray(array);

double minNum = MinElement(array);
double maxNum = MaxElement(array);
double result = DifferenceMaxMin (minNum, maxNum);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент в массиве -> {minNum}");
Console.WriteLine($"Максимальный элемент в массиве -> {maxNum}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами -> {result}");


double MinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

double MaxElement (double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double DifferenceMaxMin(double minNum, double maxNum)
{
    double differenceMaxMin = (maxNum - minNum);
    differenceMaxMin = Math.Round(differenceMaxMin, 1);
    return differenceMaxMin;
}

double[] CreateArreyRndDouble(int size, int min, int max)   //int round = 1 - можно тоже добавлять этот параметр
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}