// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int degree = Degree(numberA, numberB);
Console.WriteLine($"Число {numberA} в натуральной степени {numberB} равно: {degree}");

int Degree (int numA, int numB)
{
    int result = 1;

    for (int i = 1; i <= numB; i++)
    {
        result *= numA;
    }
    return result;
}