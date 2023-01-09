/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/


Console.Clear();
Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
int digit = int.Parse(Console.ReadLine()!);

if (digit < 1 || digit > 7)
{
    Console.Write($"Число {digit} не входит в диапазон от 1 до 7");
}
else if (digit >= 1 && digit < 6)
{
        Console.WriteLine($"{digit} день недели не является выходным");
}
else 
{
        Console.WriteLine($"{digit} день недели является выходным");
}