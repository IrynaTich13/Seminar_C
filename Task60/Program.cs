// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] array3 = CreateMatrix3D(2, 8, 8);

if (Verivication(array3))
{
    Console.WriteLine("Заданы слишком большие исходные дынные для создания массива с уникальными двузначными числами.");
    return;
}
PrintMatrix3D(array3);


int[,,] CreateMatrix3D(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
   
    int number = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = number;
                number += 1;
            }
        }

    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

bool Verivication(int[,,] matrix3D)
{
    return matrix3D.Length > 99;
}

////////////////////////////

// int[,,] Create3DMatrix(int rows, int columns, int layers, int num)
// {
//     int[,,] arr3d = new int[rows, columns, layers];

//     if (rows * columns * layers < 99)
//     {
//         for (int i = 0; i < arr3d.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr3d.GetLength(1); j++)
//             {
//                 for (int k = 0; k < arr3d.GetLength(2); k++)
//                 {
//                     arr3d[i, j, k] = num++;
//                 }
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine("Слишком большой массив для уникальных двухзначных чисел");
//     }
//     return arr3d;
// }

// void Print3DArray(int[,,] arr3d)
// {
//     for (int i = 0; i < arr3d.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr3d.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr3d.GetLength(2); k++)
//             {
//                 Console.Write($"[{i},{j},{k}] {arr3d[i, j, k]} ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] matrix3d = Create3DMatrix(2, 2, 5, 11);
// Print3DArray(matrix3d);

// /////////////////////////////////////

// int[,,] threeDArray = Create3DArray(4, 5, 2, 10, 100);

// Print3DArray(threeDArray);

// int[,,] Create3DArray(int x, int y, int z, int min, int max)
// {
//   int[,,] arr = new int[x, y, z];
//   Random rnd = new Random();

//   for (int i = 0; i < arr.GetLength(0); i++) //длинна
//   {
//     for (int j = 0; j < arr.GetLength(1); j++) //высота
//     {
//       for (int k = 0; k < arr.GetLength(2); k++) //ширина
//       {
//         int next = 0;
//         while (true)
//         {
//           next = rnd.Next(min, max);
//           if (!Contains(arr, next))
//             break;
//         }
//         arr[i, j, k] = next;
//       }
//     }
//   }
//   return arr;
// }

// bool Contains(int[,,] arr, int num)
// {
//   for (int i = 0; i < arr.GetLength(0); i++)
//   {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//       for (int k = 0; k < arr.GetLength(2); k++)
//       {
//         if (arr[i, j, k] == num) return true;
//       }
//     }
//   }
//   return false;
// }

// void Print3DArray(int[,,] arr)
// {
//   for (int i = 0; i < arr.GetLength(0); i++)
//   {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//       for (int k = 0; k < arr.GetLength(2); k++)
//       {
//         Console.WriteLine($"{arr[i, j, k]} ({i}, {j}, {k})");
//       }
//     }
//   }
// }