// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondnumber = int.Parse(Console.ReadLine()!);
int max = firstnumber;
int min = secondnumber;

if (firstnumber>secondnumber)
{
    Console.WriteLine($"max = {firstnumber}, min = {secondnumber}");
}
else if (firstnumber<secondnumber)
{
    Console.WriteLine($"max = {secondnumber}, min = {firstnumber}");
}
else
{
    Console.Write("Числа равны");
}
