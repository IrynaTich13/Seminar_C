// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату первой точки по х: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по y: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату второй точки по х: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по y: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между введёнными точками - {resRound}");

double Distance(int x1, int y1, int x2, int y2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    double c = Math.Sqrt(x*x+y*y);
    return c;
}


// double d = Math.Sqrt(5);
// double res = 5.099987564;
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(resRound);

