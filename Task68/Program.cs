// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine($"Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

if(Verification(m, n))
{
    Console.WriteLine($"Введены некорректные данные.");
    return;
}

int result = Akkerman(m, n);
Console.WriteLine($"Результат выполнения функции Аккерамана({m},{n}) равен: {result}");

int Akkerman(int num1, int num2)
{
    while (num1 != 0)
    {
        if (num2 == 0) num2 = 1;
        else num2 = Akkerman(num1, num2 - 1);

        num1 -= 1;
    }
    return num2 + 1;
}

bool Verification(int m, int n)
{
    return (m < 0 || n < 0);
}

// int Akkerman(int num1, int num2)
// {
//     if (num1 == 0) return num2 + 1;
//     if (num2 == 0) return Akkerman(num1 - 1, 1);
//     return Akkerman (num1 - 1, Akkerman(num1, num2 - 1));
// }