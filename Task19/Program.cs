// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * -1;
if (number > 9999 && number < 100000)
{
    bool result = Palindrom(number);
    Console.WriteLine(result ? "Введённое число является палиндромом" : "Введённое число НЕ является палиндромом");
}
else
    Console.Write("Вы ввели не пятизначное число");

bool Palindrom(int num)
{
    int firstnum = num;
    int reversNum = 0;

    while (num > 0)
    {
        reversNum = reversNum * 10 + num % 10;
        num /= 10;
    }
    return reversNum == firstnum;
}


// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0) num = num * -1;
// if (num < 10000 || num > 100000)
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
// }
// else
// {
//     Palindrome(num);
//     void Palindrome(int number)
//     {
//         if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num % 100) / 10))
//             Console.WriteLine("Введённое число является палиндромом");

//         else Console.WriteLine("Введённое число НЕ является палиндромом");
//     }
// }

//(num / 10000 == num % 10) - сраниваем 1 и 5 цифры
//(num / 1000) % 10 == (num % 100) / 10) - сравниваем 2 и 4 цифры