// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите длину массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArreyInput(arrSize);

int countnum = CountPositivNum(arr);

PrintArray(arr);

Console.Write($" Колличество положительных чисел равно {countnum}");

int[] CreateArreyInput(int length)
{
    int[] newArray = new int[length];

    for (int i = 0; i < length; i++)      // либо for (int i = 0; i < size; i++)
    {
         Console.Write($"Введите {i + 1} число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

int CountPositivNum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}