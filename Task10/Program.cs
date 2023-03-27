// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondNumber(number);

if (number > 99 && number < 1000)
    Console.WriteLine($"Вторая цифра числа - {result}");
else
    Console.WriteLine("Вы ввели не трёхзначное число");

int SecondNumber(int num)
{
    return num / 10 % 10;
}
