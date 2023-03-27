// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, интересующего дня недели, от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
{
bool result = DayOff(day);
Console.Write(result ? "Да" : "Нет");
}
else
Console.Write("Такого дня недели не существует");

bool DayOff(int num)
{
    return num == 6 || num == 7;
}