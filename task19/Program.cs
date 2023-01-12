/* Задача 19. Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.*/

Console.Clear();
Console.Write("Введите пятизначное число: ");
int digit = int.Parse(Console.ReadLine()!);

int firstnumber = digit / 10000 % 10;
int secondnumber = digit / 1000 % 10;
int fourthnumber = digit / 10 % 10;
int fifthnumber = digit % 10;

if (digit < 10000 || digit > 99999)
{
    Console.Write($"Число {digit} не является пятизначным");
}
else if (firstnumber == fifthnumber && secondnumber == fourthnumber)
{
    Console.Write($"Число {digit} является палиндромом");
}
else
{
        Console.WriteLine($"Число {digit} не является палиндромом");
}

