// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// не забываем проверку! М может быть больше N, может быть меньше N, может быть равно N


Console.WriteLine($"Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите последнее число: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(m, n);

void NaturalNumbersRange(int start, int finish)
{
    //Console.Write($"{start } ");
    if (start < finish)
    {
        Console.Write($"{start} ");
        NaturalNumbersRange(start + 1, finish);
    }
    else if (start > finish)
    {
        Console.Write($"{start} ");
        NaturalNumbersRange(start - 1, finish);
    }
    else
    {
        Console.WriteLine(start);
    }
}