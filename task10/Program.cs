/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.*/

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 100 || number > 999)
{
    Console.Write($"Число {number} не является трёхзначным");
}
else
{
    int SecondDigit = number / 10 % 10;
    Console.WriteLine($"Вторая цифра числа {number} равна {SecondDigit}");
}
