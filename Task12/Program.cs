// 12. Напишите программу, которая будет 
// 1. принимать на вход два числа и 
// 2. выводить, является ли первое число кратным второму. 
// 3. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Write("Введите 1-ое целое положительное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое целое положительное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

//int remainder = number1 % number2;

int remainder = RemainderDivision(number1, number2);

Console.WriteLine(remainder == 0 ? "кратно" : $"не кратно, остаток {remainder}" );

// if(remainder == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток -> {remainder}");
// }
//Console.WriteLine(remainder);

int RemainderDivision(int num1, int num2)
{
    return num1 % num2;
}