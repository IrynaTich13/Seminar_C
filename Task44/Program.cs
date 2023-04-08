// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1) PrintArray(FiboArray(num));
else Console.Write("Колличество чисел для вычисления Фибоначчи должно быть не меньше 2 ");

int[] FiboArray(int number)
{
    int[] array = new int[number];
    // array[0] = 0; это значение не имеет смысла, потому что 0 уже есть по умолчанию
    array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
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