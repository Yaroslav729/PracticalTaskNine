// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);

int summa(int n, int m)
{ 
    if (n == m)
        return 0;
    else
    {  
        n++;
        return n + summa(n, m);
    }
}
Console.Write(summa(n - 1, m));