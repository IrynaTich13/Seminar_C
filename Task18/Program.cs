// Задача 18: Напишите программу, которая 
// по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти от 1 до 4: ");

//int number = Convert.ToInt32(Console.ReadLine()); - нет необходимости преобразовывать ввод пользователя в цифру. Тогда см. строку 8

string result = Console.ReadLine();  // к этому условию - смотри второй метод

string num = RangeCoordinate(result);
Console.WriteLine(num);

// string number1 = RangeCoordinate(number);
// string result = number < 5 && number > 0 
// ? $"Диапазон возможных координат точек в этой четверти: {number1}"
// : "Неверно";
// Console.WriteLine(result);

// // string RangeCoordinate (int num)
// {
//     if (num == 1) return "x > 0, y > 0";
//     if (num == 2) return "x < 0, y > 0";
//     if (num == 3) return "x < 0, y < 0";
//     if (num == 4) return "x > 0, y < 0";
//     return "Номер четверти введён некорректно";
// }

string RangeCoordinate (string num)
{
    if (num == "1") return "x > 0, y > 0";
    if (num == "2") return "x < 0, y > 0";
    if (num == "3") return "x < 0, y < 0";
    if (num == "4") return "x > 0, y < 0";
    return "Номер четверти введён некорректно";
}