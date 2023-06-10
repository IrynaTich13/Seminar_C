// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine($"Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int sumNum = 0;

if (Verification(m, n))
{
    Console.Write($"Введены не натуральные числа.");
    return;
}

if (m <= n)
    sumNum = SumNaturalNumber(m, n);

if (m > n)
    sumNum = SumNaturalNumber(n, m);

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна: {sumNum}");

int SumNaturalNumber(int num1, int num2)
{
    if (num1 == num2) return num2;
    else return num1 + SumNaturalNumber(num1 + 1, num2);
}

bool Verification(int num1, int num2)
{
    return (num1 <= 0 || num2 <= 0);
}