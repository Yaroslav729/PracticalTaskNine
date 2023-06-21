// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Main(args);
void Print(int i)
{
    if (i >= number)
    return;
    i++;
    Print(i);
    Console.Write($"{i}, ");
}

void Main(string[] args)
{
    Print(0);
}
