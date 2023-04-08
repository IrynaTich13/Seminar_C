// Задача 45: Напишите программу, которая 
// будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] array = CreateArreyRndInt(7, 0, 10);
PrintArray(array);

Console.WriteLine();
int[] copyArr = CopyArray(array);
//  copyArr[0] = 12; - это проверка на то, что мы действительно создали копию, а не скопировали ссылку
PrintArray(copyArr);


int[] CreateArreyRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)      // либо for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int[] CopyArray (int[] arr)
{
    int[] copyArrey = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
      copyArrey[i] = arr[i]; 
    }
    return copyArrey;
}