// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
Console.Clear();

Console.Write("Введите начальное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное число N: ");
int n = int.Parse(Console.ReadLine()!);

int AckermannFunction (int m, int n)
{
    if (m == 0)
    return n + 1;

    if (m != 0 && n == 0) 
    return AckermannFunction(m - 1, 1);

    if (m > 0 && n > 0) 
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return AckermannFunction(m, n);
}

Console.WriteLine($"({m},{n}) = {AckermannFunction(m, n)}");


