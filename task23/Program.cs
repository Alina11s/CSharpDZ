/* Задача 23. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/

Console.Clear();
int getUserValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int N = getUserValue("Введите число: ");
int i = 1;

while (i <= N)
{
    Console.Write(Math.Pow(i, 3) + ", ");
    i++;
}