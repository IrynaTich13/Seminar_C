//Задача 42: Напишите программу, которая будет 
//преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10


// int decimal1 = 2;
// string result = DecToBin(decimal1);

// Console.WriteLine(result);

// string DecToBinString(int decimaNumber)
// {
//     if (decimaNumber == 0 || decimaNumber == 1)
//     {
//         return Convert.ToString(decimaNumber);
//     }
    
//     string dec = string.Empty;
//     while (decimaNumber > 0)
//     {
//         dec = decimaNumber % 2 + dec;
//         decimaNumber /= 2;
//     }
//     return dec;
// }

int decimal1 = 2;
int result = DecToBinInt(decimal1);

Console.WriteLine(result);

int DecToBinInt(int decimaNumber)
{
    if (decimaNumber == 0 || decimaNumber == 1)
    {
        return decimaNumber;
    }
    
    int dec = 0;
    int i = 1;
    while (decimaNumber > 0)
    {
        dec = dec + decimaNumber % 2 * i;
        decimaNumber /= 2;
        i *= 10;
    }
    return dec;
}