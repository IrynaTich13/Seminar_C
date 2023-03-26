// 14. Напишите программу, которая 
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultTwoNumbers(number, 7, 23);
Console.WriteLine(result ? "Да" : "Нет");

bool MultTwoNumbers(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}