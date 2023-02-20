/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.*/

Console.Clear();
int getFromUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}


int userNumberStart = getFromUserData("Введите M: ");
int userNumberFinish = getFromUserData("Введите N: ");

int getSumOfNumber(int userNumberStart, int userNumberFinish)
{
    if (userNumberStart == userNumberFinish)
    {
        return userNumberStart;
    }
    return userNumberStart + getSumOfNumber(userNumberStart + 1, userNumberFinish);
}

int result = getSumOfNumber(userNumberStart, userNumberFinish);
Console.WriteLine(result);

