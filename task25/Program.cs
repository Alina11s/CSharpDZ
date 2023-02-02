/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.*/

Console.Clear();
int getUserNumber(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int A = getUserNumber("Введите число A: ");
int end = getUserNumber("Введите число B: ");

double getPow(int start, int end)
{
    double pr = 1;
    for (int B = start; B <= end; B++ )
    {
        pr = pr * A;
    }
    return pr;
}

double pr = getPow(1,end);
Console.WriteLine($"Число {A} в степени {end} равно {pr}");

