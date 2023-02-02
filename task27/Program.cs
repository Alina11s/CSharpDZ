/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.*/

Console.Clear();
int getUserNumber(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int getSumOfnumber (int number)
{
    int sum = 0;
    int A = 0;
    while (number > 0)
    {
        A = number % 10;
        number = number / 10;
        sum = sum + A;
    }
    return sum;
}

int number = getUserNumber("Введите число: ");
int sum = getSumOfnumber(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
