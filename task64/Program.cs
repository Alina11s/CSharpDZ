/* Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1.*/

Console.Clear();
int getFromUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int userNumber = getFromUserData("Введите N: ");
printRange(userNumber);

void printRange(int N)
{
    if (N == 0)
    {
        return;
    }
    Console.Write(N + ",");
    printRange(N - 1);
}