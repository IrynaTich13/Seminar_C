// 16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsEqualSquared(number1, number2);
Console.WriteLine(result ? "Да" : "Нет");

bool IsEqualSquared(int num1, int num2)
{
   return num1 * num1 == num2  || num2 * num2 == num1;
}