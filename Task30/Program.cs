// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Решение правильное, но смотрие ещё ниже - оно ещё правильнее

// int[] array = new int[8];

// Fullness(array);
// PrintArray(array);

// void Fullness(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
// }

// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
//      {
//          Console.Write (array[i]+" ");
//      }
// }

////////////////////////////////////////////РЕШЕНИЕ ОЧЕНЬ ХОРОШЕЕ - 51 СТРОКА - ПОИСК РАНДОМ ВЫВОДИТСЯ ОТДЕЛЬНО

Console.Clear();

Console.Write("Введите размер массива: ");

int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize <= 0)
{
    Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
    return;
}

int[] arr = CreateArray(arraySize);

PrintArray(arr);

int[] CreateArray(int arrayLength)
{
    int[] newArray = new int[arrayLength];

    Random random = new Random();

    for (int i = 0; i < arrayLength; i++)
    {
        newArray[i] = random.Next(0, 2);
    }

    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//         for (int i = 0; i <= 1; i++)
//         {
//             int minPosition = i;

//      }
// }

// PrintArray(arr);
// SelectionSort(arr);