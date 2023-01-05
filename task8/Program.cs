// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int C = 2;

while (C<=N)
{
    Console.Write(C+" ");
    C = C + 2;
}
