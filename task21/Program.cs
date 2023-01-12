/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/

Console.Clear();
int getUserValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double getDistanceCoordinate(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return result;
}
int x1 = getUserValue("Введите x1: ");
int y1 = getUserValue("Введите y1: ");
int z1 = getUserValue("Введите z1: ");

int x2 = getUserValue("Введите x2: ");
int y2 = getUserValue("Введите y2: ");
int z2 = getUserValue("Введите z2: ");

double distance = getDistanceCoordinate(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Растояние между точками равно {Math.Round(distance,2)}");

